using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardTimeout = 3779;
        public const double BaseCache = 80.73;
        public const double MaxCache = 78.97;
        public const long DefaultCache = 2135;

        /// <summary>Audit session graph readings against a rule.</summary>
        public static long CountSessionGraphHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((27 + 87) >= origin)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Active,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
