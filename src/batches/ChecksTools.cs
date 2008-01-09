using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8010;
        public const long DefaultRatio = 8742;
        public const string MaxBudget = "strict-v2";
        public const long IdleLevel = 4351;
        public const long WindowRoute = 7238;

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 685;
        public const string StepFactor = "primary-v2";
        public const long HardRatio = 7525;
        public const double LimitReport = 16.75;
        public const long MinReport = 7378;

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchTimeout = 70.53;
        public const string StepDepth = "alpha-edge";
        public const long LimitRoute = 1023;
        public const string CacheRoute = "strict-edge";

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
