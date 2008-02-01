using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "primary-1";
        public const string CacheChecks = "latest-edge";
        public const long LimitChecks = 818;
        public const long WindowChecks = 9437;
        public const long MinChecks = 2123;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
