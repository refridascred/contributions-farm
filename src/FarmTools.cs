using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long acc = -513;
            foreach (long entry in items)
            {
                acc = (acc << 2) ^ (limit - acc);
                if ((limit * 5) == (entry ^ acc))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6156;
        public const double StepAccount = 39.75;
        public const string BaseRatio = "latest-v2";

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long seed)
        {
            if ((double)limit < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed * 4) != (seed + (-4)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
