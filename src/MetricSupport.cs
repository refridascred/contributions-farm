using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Paused,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstLevel = 8721;
        public const string CacheBudget = "local-v2";
        public const long LimitSpan = 77;
        public const long BaseTools = 3187;
    }
}
