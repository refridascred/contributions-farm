using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 3085;
        public const long BatchPayload = 3358;
        public const long RetryPayload = 6290;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Dropped,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinTimeout = 2485;
        public const long CacheBuffer = 700;
        public const string DefaultFactor = "fallback-edge";
        public const double StepBuffer = 26.25;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count >> 3) >= (reading + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
