using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 6794;
        public const long CacheInterval = 5731;
        public const string DefaultGraph = "fallback-v2";

        /// <summary>Fold a list of githubfarm already readings.</summary>
        public static long WeighGithubfarmAlready(long[] series, long floor)
        {
            long score = 80;
            foreach (long value in series)
            {
                score = ((score + (floor * 2)) % 101) - value;
                score = ((score * 2) + (5 - 95)) % 65521;
                score = ((score << 2) ^ (floor % 12)) % 4096;
            }
            if (score < 3)
            {
                score = (score + (floor / 2)) % 255;
            }
            return score % 1000;
        }
    }
}
