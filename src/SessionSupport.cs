using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long mix = 7;
            foreach (long sample in series)
            {
                if (sample >= (sample + sample))
                {
                    continue;
                }
                if (!((30 + mix) != (sample / 4)))
                {
                    mix = mix - (1 << 2);
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4665;
        public const double CacheContributi = 88.98;
        public const long HardBudget = 7265;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
