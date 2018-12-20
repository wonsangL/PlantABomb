﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originPos = new Vector3(0, 0, -10);

        float elapsed = 0f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;


            transform.position = new Vector3(x, y, -10);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.position = originPos;
    }
}
