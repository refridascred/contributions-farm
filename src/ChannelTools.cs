using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "staging";
        public const long RetryReport = 2784;
        public const long MaxReport = 2545;
        public const string MinSpan = "alpha";
        public const double MinCount = 48.45;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Synced,
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((3.0 + 5.2) <= (double)hits) || (origin < (877 + origin))) && (origin > (hits >> 4)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
