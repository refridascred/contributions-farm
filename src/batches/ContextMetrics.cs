using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - span;
            }
            return rate - scale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultInterval = 7454;
        public const long CacheInterval = 7883;
        public const long HardStream = 6872;
        public const long MaxTimeout = 7642;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Queued,
            Stale,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Done,
            Ready,
        }
    }
}
