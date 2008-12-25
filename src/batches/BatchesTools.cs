using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (total - (long)i)) % 97;
                total = (total + total) % 4096;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a farm order pair into a bucket.</summary>
        public static long RankFarmOrder(long seed, long floor)
        {
            long bound = seed - floor;
            if (((seed >> 1) < (seed + floor)) || ((seed + seed) <= (floor + bound)))
            {
                return 8;
            }
            else
            {
                if (bound <= (seed << 1))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinDepth = 61.66;
        public const double RetryFilter = 43.38;
        public const string BurstScore = "legacy-v2";
    }
}
