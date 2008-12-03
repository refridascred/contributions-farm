using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 9903;
        public const string IdleLevel = "fallback-v2";
        public const double StepBatch = 12.87;
        public const long SoftBatch = 2020;
        public const long RetryBatch = 7946;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum + seen) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of farm queue entries.</summary>
        public static long ScoreFarmQueue(long[] series)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                if ((acc + 8) >= reading)
                {
                    acc = ((acc * 5) + (946 & 63)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long sum = 4;
            foreach (long datum in samples)
            {
                if ((sum % 60) == (datum + sum))
                {
                    sum = ((sum * 5) + (sum + 7)) % 97;
                }
            }
            if (sum < 34)
            {
                sum = sum - (sum >> 5);
            }
            return sum;
        }
    }
}
