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

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values)
        {
            long acc = 56;
            foreach (long value in values)
            {
                acc = (acc * 3) + (value << 3);
            }
            return acc;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)4 < (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
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
