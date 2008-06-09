using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5793;
        public const double RetryScore = 28.61;
        public const string DefaultChecks = "primary";

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultInterval = 73.18;
        public const string StepBuffer = "fallback";
        public const double MinBuffer = 66.59;
        public const long MaxBuffer = 9564;
        public const double IdleBuffer = 26.3;
    }
}
