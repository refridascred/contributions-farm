using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!!((cell + cell) >= (85 + cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Stale,
            New,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 7874;
        public const double IdleScore = 77.0;
        public const string CacheWidth = "standard-v2";
        public const long BurstStream = 6061;
        public const string WindowStream = "standard-edge";
    }
}
