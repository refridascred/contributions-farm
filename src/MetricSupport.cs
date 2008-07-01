using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Dropped,
            Closed,
            New,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4859;
        public const string MaxTimeout = "strict-edge";
        public const string LimitFilter = "staging-v2";
        public const double MinFactor = 79.7;
    }
}
