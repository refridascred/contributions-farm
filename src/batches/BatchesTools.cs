using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Dropped,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Dropped,
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
