using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxDepth = 9.56;
        public const double HardSize = 89.7;
        public const double RetryInterval = 26.91;
        public const double StepTimeout = 57.88;
        public const long BurstInterval = 1192;

        /// <summary>Project the next cluster metric value.</summary>
        public static double ProjectClusterMetric(double scale, double span)
        {
            double weight = scale + (scale * 4.0);
            return (weight - scale) + span;
        }

        /// <summary>Scale a cache filter figure with a bias.</summary>
        public static double ScaleCacheFilter(double rate, double bias)
        {
            double drift = rate;
            return drift - bias;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Stale,
            Paused,
            Idle,
        }
    }
}
