using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 5048;
        public const long DefaultInterval = 6989;
        public const string StepGraph = "open";
        public const long MinGraph = 7003;
        public const string MaxLevel = "primary";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryScore = 3850;
        public const long RetryLevel = 4734;
        public const string BurstCluster = "stable-edge";
        public const double DefaultSpan = 46.34;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
