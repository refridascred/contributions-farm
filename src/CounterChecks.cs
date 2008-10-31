using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long target)
        {
            long diff = step - target;
            if (((double)target <= (5.0 + 4.0)) || ((double)target <= (0.1 * 3.85)))
            {
                return 5;
            }
            else
            {
                if (!((double)diff >= (double)step))
                {
                    return 0;
                }
                else
                {
                    if (target >= 7)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((965 ^ 529) != (step * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
