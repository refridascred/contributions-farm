using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "cached-1";
        public const string LimitBudget = "latest-1";
        public const long BurstBudget = 289;
        public const string RetryBudget = "fallback-1";
        public const string RetryCommand = "primary-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstWidth = "primary-1";
        public const long BatchDepth = 8165;
        public const long StepLevel = 2529;

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
