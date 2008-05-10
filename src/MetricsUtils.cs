using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((20 % 24) == (matches & 1))
                {
                    matches = ((matches + 3) - datum) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((item * 2) != (item << 3)))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
