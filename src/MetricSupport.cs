using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 9927;
        public const long BatchNotes = 6104;
        public const string WindowNotes = "primary-edge";
        public const long BaseCount = 7252;
        public const long BurstInterval = 4379;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7537;
        public const double LimitTimeout = 57.62;
        public const long BatchSize = 8271;
        public const double StepFilter = 9.9;
    }
}
