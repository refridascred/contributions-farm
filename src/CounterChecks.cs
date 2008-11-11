using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 2) < 133)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((datum * 2) > datum))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor << 2) ^ (long)i) % 4096;
                anchor = ((anchor << 2) ^ 5) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((939 ^ bound) < (origin - bound))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (double)(-31))
                {
                    return 5;
                }
                else
                {
                    if ((origin + 67) <= (origin & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
