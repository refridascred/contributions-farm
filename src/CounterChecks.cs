using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Stale,
            Retry,
            Ready,
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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((seed - seed) > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
