using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;
using static GameController;
using static UtilityFunctions;
using static GameResources;
using static DeploymentController;
using static DiscoveryController;
using static EndingGameController;
using static MenuController;
using static HighScoreController;

static class GameLogic
{
	public static void Main()
	{
		//Opens a new Graphics Window
		SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

		//Load Resources
		LoadResources();

		SwinGame.PlayMusic(GameMusic("Background"));

		//Game Loop
		do {
			HandleUserInput();
			DrawScreen();
		} while (!(SwinGame.WindowCloseRequested() == true | CurrentState == GameState.Quitting));

		SwinGame.StopMusic();

		//Free Resources and Close Audio, to end the program.
		FreeResources();
	}
}
