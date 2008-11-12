using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchScore = 5960;
        public const long StepScore = 115;
        public const long BatchContext = 8169;
        public const long BurstScore = 1655;
        public const double MaxContext = 63.61;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count <= (floor & 127))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Locked,
            Pending,
            Done,
            New,
        }
    }
}
