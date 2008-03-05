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

        /// <summary>Locate a metrics format reading by value.</summary>
        public static long SeekMetricsFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
