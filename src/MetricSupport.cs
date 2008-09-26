using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Closed,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5425;
        public const string SoftQueue = "local";
        public const double BurstInterval = 85.48;
        public const long HardQueue = 3584;
        public const long BaseBudget = 6358;
    }
}
