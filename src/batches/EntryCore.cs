using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many metric channel samples are out of range.</summary>
        public static long AuditMetricChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count <= 9.77)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((hits + entry) == (entry * 5)) && (3 > (hits - hits))) || (((double)entry < (12.0 - 4.42)) || ((65 % 97) > (hits << 1))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 2707;
        public const double DefaultMetric = 3.9;
        public const long MinSpan = 5741;
        public const string LimitScore = "staging-v2";
    }
}
