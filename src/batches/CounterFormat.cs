using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                long lane = total - total;
                total = (total + ((long)i + lane)) % 65521;
                total = (total - (total / 9)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            New,
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 2637;
        public const string DefaultCache = "local-1";
        public const string BatchLevel = "standard-edge";
        public const long BatchSpan = 1549;
    }
}
