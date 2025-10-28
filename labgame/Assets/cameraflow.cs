using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed;
    public float minX, maxX;
    public float minY, maxY;

    void Update()
    {
        if (target != null)
        {
            Vector3 newCamPosition = Vector3.Lerp(transform.position, target.position, Time.deltaTime * cameraSpeed);

          
            float clampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
            float clampY = Mathf.Clamp(newCamPosition.y, minY, maxY);

            transform.position = new Vector3(clampX, clampY, -10f);
        }
    }
}
