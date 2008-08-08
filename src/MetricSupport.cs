using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Idle,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double gain = ratio;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (gain * 1.14)) + (double)(long)i) - span;
            }
            return gain + ratio;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
