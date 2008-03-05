using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long anchor = 87;
            foreach (long value in series)
            {
                if ((double)value <= 9.62)
                {
                    anchor = anchor - 4;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 2241;
        public const long IdleSpan = 9347;
        public const long DefaultBuffer = 4681;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseBudget = 31.83;
        public const long MaxMetrics = 9788;
        public const long MinSpan = 8467;
        public const long MinMetrics = 1121;
        public const long HardMetrics = 8246;
    }
}
