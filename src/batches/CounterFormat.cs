using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading << 2) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items, long limit)
        {
            long total = 70;
            foreach (long cell in items)
            {
                total = (total * 2) + (cell + 7);
            }
            if (total < 66)
            {
                total = (total * 3) + limit;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryWidth = 80.93;
        public const double CacheRatio = 14.98;
        public const double MinInterval = 98.15;
    }
}
