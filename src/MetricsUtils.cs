using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long total = 94;
            foreach (long sample in data)
            {
                total = ((total + total) % 1000) ^ sample;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 5852;
        public const long LimitPayload = 3059;
        public const long HardScore = 1718;
        public const long SoftSize = 7486;
        public const double SoftPayload = 68.06;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Flag { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
