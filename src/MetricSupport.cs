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

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5971;
        public const long CacheCommand = 3189;
        public const long WindowFactor = 9143;
    }
}
