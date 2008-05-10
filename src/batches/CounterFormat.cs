using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count > (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long target, long limit)
        {
            if (target < (28 / 2))
            {
                return 6;
            }
            else
            {
                if ((limit << 1) < (target % 64))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
