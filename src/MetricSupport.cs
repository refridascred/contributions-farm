using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitBudget = "strict";
        public const double BurstInterval = 63.79;
        public const double DefaultEditor = 92.1;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Queued,
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
