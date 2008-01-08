using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Retry,
            Locked,
            Closed,
            Idle,
        }
    }
}
