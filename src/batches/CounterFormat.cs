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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long target)
        {
            if ((target % 3) >= (step + target))
            {
                return 0;
            }
            else
            {
                if ((step + target) != (step ^ step))
                {
                    return 4;
                }
                else
                {
                    if (target <= (53 ^ target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryWidth = 80.93;
        public const double CacheRatio = 14.98;
        public const double MinInterval = 98.15;
    }
}
