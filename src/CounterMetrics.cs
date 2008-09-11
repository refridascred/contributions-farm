using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftDepth = 234;
        public const long BaseInterval = 3467;
        public const double BurstSize = 63.9;
        public const long MaxBudget = 463;
        public const long StepSpan = 203;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Draft,
            Closed,
        }
    }
}
