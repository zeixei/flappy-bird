using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    
    public GameObject gameOverCanvas;
    public GameObject replayButton;
    public GameObject flap;

    // Start is called before the first frame update
    private void Start()
    {
        replayButton.SetActive(false);
        gameOverCanvas.SetActive(false);
        flap.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()// Update is called once per frame
    {
        replayButton.SetActive(true);
        gameOverCanvas.SetActive(true);
        flap.SetActive(true);
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}

