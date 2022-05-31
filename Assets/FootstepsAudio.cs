using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsAudio : MonoBehaviour

{ 
    private AudioSource audio;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        audio.Play();
    }
}