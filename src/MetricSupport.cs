using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Offset { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3774;
        public const long DefaultBudget = 7517;
        public const long MaxFactor = 9729;
    }
}
