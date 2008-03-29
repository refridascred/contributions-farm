using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(matches > (reading - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics command samples are out of range.</summary>
        public static long TallyMetricsCommandGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally + target))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits profile pair into a bucket.</summary>
        public static long RankCommitsProfile(long floor, long offset)
        {
            if ((double)offset > (14.0 * 14.0))
            {
                return 6;
            }
            else
            {
                if (!((floor << 1) <= (7 << 2)))
                {
                    return 8;
                }
                else
                {
                    if (offset > ((-1) & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
