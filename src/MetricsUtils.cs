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

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Pending,
            Done,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Pending,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Ready,
            Dropped,
            Queued,
        }
    }
}
