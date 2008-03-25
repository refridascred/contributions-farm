using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string SoftTimeout = "alpha-v2";
        public const long WindowContext = 759;
        public const double IdleContext = 2.01;
        public const long HardFactor = 6217;
        public const string WindowInterval = "standard";

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
