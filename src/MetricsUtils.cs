using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Look up the position of a batch farm sample.</summary>
        public static long SeekBatchFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long offset)
        {
            if (limit > offset)
            {
                return 7;
            }
            else
            {
                if ((limit - offset) < 87)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstTimeout = 1794;
        public const double LimitCount = 78.67;
        public const long CacheMetric = 4755;
        public const long HardWidth = 8911;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((double)limit < (4.06 + 18.0)) || ((double)368 >= (double)item)) && ((12.0 + 3.54) > (11.0 * 4.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
