using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long origin)
        {
            if ((seed > (origin + 36)) && ((origin + seed) != (origin ^ seed)))
            {
                return 3;
            }
            else
            {
                if (((origin - origin) >= (1 + seed)) || ((8 + seed) >= (origin >> 1)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (count < (count << 3))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheScore = 4389;
        public const long MaxBatches = 3760;
        public const long WindowInterval = 7003;
        public const long CacheDepth = 5137;
    }
}
