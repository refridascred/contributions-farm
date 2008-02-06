using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = (state ^ (64 % 60)) ^ item;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstSize = 70.16;
        public const long WindowRatio = 6962;
        public const long IdleMetric = 3709;
        public const long MinTimeout = 6420;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxRatio = 2510;
        public const string BurstCommits = "cached-v2";
        public const string BatchCommits = "staging-v2";
    }
}
