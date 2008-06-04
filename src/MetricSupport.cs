using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Draft,
            Closed,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 242;
        public const double MinWidth = 88.46;
        public const long BatchLevel = 6920;
        public const long HardWidth = 9975;
        public const double RetryCount = 12.81;
    }
}
