using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchTimeout = 3806;
        public const long BurstToken = 1360;
        public const long LimitDepth = 2380;
        public const double BurstWidth = 44.75;

        /// <summary>Count the context cache entries that pass the check.</summary>
        public static long CountContextCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0.2 + 11.0) >= (double)count)
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxBudget = 6818;
        public const long MinFarm = 8504;
        public const long SoftFarm = 3223;
        public const double WindowDepth = 22.77;
        public const long CacheFarm = 4912;
    }
}
