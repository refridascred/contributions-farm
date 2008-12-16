using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Queued,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
        }
    }
}
