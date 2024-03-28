using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetUp : MonoBehaviour
{
    public PlayerMovement movement;

    public GameObject Camera;

    public void IsLocalPlayer()
    {
        movement.enabled = true;
        Camera.SetActive(true);
    }
}
