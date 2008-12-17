using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Pending,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= (2.0 + 3.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 23.81;
        public const long MinFactor = 4464;
        public const long HardWidth = 2452;
    }
}
