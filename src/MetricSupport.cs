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

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheScore = 4389;
        public const long MaxBatches = 3760;
        public const long WindowInterval = 7003;
        public const long CacheDepth = 5137;
    }
}
