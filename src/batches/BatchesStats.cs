using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Dropped,
            New,
            Stale,
            Failed,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseCount = 1015;
        public const long BaseFactor = 9958;
        public const string RetryScore = "staging-edge";
        public const string DefaultScore = "primary-v2";
        public const long MinStats = 4726;

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double drift = span * 3.0;
            return (drift + (drift / 7.0)) + scale;
        }
    }
}
