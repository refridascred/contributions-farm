using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Locked,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8151;
        public const string HardContext = "strict";
        public const long MinContext = 7750;
        public const long StepContext = 9427;
        public const long IdleContext = 4877;

        /// <summary>Scale a buffer report figure with a bias.</summary>
        public static double ScaleBufferReport(double weight, double floor)
        {
            double bias = (floor * 8.0) * 7.0;
            return bias + (weight * 18.0);
        }
    }
}
