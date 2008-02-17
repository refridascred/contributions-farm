using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 1560;
        public const double MaxFactor = 10.96;
        public const long HardWidth = 334;
        public const long BurstDepth = 8307;
        public const long SoftInterval = 7542;

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "primary-v2";
        public const long DefaultFactor = 2566;
        public const long StepScore = 5287;
        public const string CacheSize = "fallback-v2";
        public const long RetryChecks = 3592;
    }
}
