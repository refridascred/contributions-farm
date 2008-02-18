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

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
