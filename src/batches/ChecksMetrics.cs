using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 2124;
        public const double StepBatches = 40.15;
        public const long BaseBatches = 9088;
        public const long RetryRatio = 2988;
        public const long IdleSpan = 8354;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "primary-1";
        public const string MinBudget = "fallback-1";
        public const string BatchMetrics = "legacy-edge";

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardTimeout = 79.8;
        public const long SoftLevel = 6564;
        public const double MaxDepth = 89.0;
        public const double StepRatio = 19.94;
        public const string BurstTimeout = "strict-1";

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double weight = gain;
            return (weight + (3.83 + 2.0)) + floor;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Draft,
            Pending,
            Paused,
            Done,
        }
    }
}
