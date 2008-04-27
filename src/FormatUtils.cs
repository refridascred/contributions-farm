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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

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
