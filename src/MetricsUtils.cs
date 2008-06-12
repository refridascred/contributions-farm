using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item <= matches)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 968;
        public const long RetryMetric = 4608;
        public const double BatchSpan = 87.37;
        public const double IdleRatio = 23.25;
        public const long MaxMetric = 6291;

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
