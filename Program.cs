Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.уууу HH:mm}");

Console.WriteLine($"OC: {Environment.OSVersion}");
Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");

Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");


Console.WriteLine($"PID процесса: {Environment.ProcessId}");
long memory = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса: {memory} МБ");
Console.ReadLine();