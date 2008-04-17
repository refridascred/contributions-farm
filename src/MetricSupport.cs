using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((1.23 / 6.0) == (double)count) || (((7.3 - 17.0) == (double)entry) || ((0.08 - 3.6) < (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 9008;
        public const long BatchSize = 7529;
        public const long CacheQueue = 8416;
    }
}
