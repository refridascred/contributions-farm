using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 9394;
        public const long CacheAccount = 7602;
        public const long RetryCount = 2464;
        public const long BurstAccount = 6656;
        public const string MinFactor = "staging-1";

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long total = 13;
            foreach (long item in levels)
            {
                total = (total ^ (item >> 1)) % 97;
            }
            return total;
        }

        /// <summary>Iterate the stats payload series from a seed.</summary>
        public static long SeriesStatsPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
