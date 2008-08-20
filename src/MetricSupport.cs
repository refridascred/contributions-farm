using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Idle,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
