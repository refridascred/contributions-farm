using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 229;
        public const long DefaultWidth = 5186;
        public const double RetrySpan = 48.76;
        public const long LimitFactor = 9832;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
