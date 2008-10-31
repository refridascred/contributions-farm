using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits == (14.0 - 7.69))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Combine schema batch values into a single score.</summary>
        public static long ScoreSchemaBatch(long[] levels)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                anchor = anchor + (datum - datum);
                if ((anchor + datum) <= (anchor >> 2))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Closed,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitScore = 9.56;
        public const long StepFilter = 9409;
        public const string BaseCount = "latest";

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
