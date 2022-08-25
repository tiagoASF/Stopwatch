Menu();



static void Menu()
{
    Console.Clear();
    Console.WriteLine("S - Segundos => 10s = 10 segundos");
    Console.WriteLine("M - Minutos => 10m = 10 minutos");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string input = Console.ReadLine().ToLower();

    if (input == "0")
    {
        Console.WriteLine("Obrigado por usar nosso timer!");
        Thread.Sleep(700);
        System.Environment.Exit(0);
    }

    char typeOfTime = char.Parse(input.Substring((input.Length - 1), 1));
    int time = int.Parse(input.Substring(0, (input.Length - 1)));

    preStart();
    Start(CalculateTimeInSeconds(typeOfTime, time));

    




}

static void preStart()
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Go!");
    Thread.Sleep(1000);
}

static void Start(int time)
{
    int currentTime = 0;

    while(currentTime < time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Tempo encerrado");
    Thread.Sleep(1000);
    Menu();
}

static int CalculateTimeInSeconds(char type, int time)
{
    if (type == 'm')
    {
        return time * 60;
    }

    return time;
        
}
