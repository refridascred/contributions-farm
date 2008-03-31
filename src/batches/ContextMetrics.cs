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

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double rate, double offset)
        {
            double drift = (double)((-406) + 36);
            if (drift >= 5.8)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift - (offset * 4.62);
            }
            return drift - 3.1;
        }
    }
}
