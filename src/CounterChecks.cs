using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Total { get; set; }
            public long Flag { get; set; }
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

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
