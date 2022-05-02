using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI finalScore;
    ScoreKeeper scoreKeeper;

    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    
    void Start()
    {
        finalScore.text = "You Scored:\n" + scoreKeeper.GetScore().ToString("0000000");
    }
}
