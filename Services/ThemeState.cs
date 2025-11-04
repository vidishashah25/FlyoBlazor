namespace FlyoBlazor2.Services
{
    public class ThemeState
    {
        public bool IsDark { get; set; }
        public Func<Task>? Toggle { get; set; }
    }
}
