using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Count the session stats entries that pass the check.</summary>
        public static long AuditSessionStatsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally != (2.32 - 3.85))
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((((-1) & 7) <= (24 + item)) && (item < (seed - count))) || ((9.3 - 5.0) >= (double)seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long offset)
        {
            long span = target - offset;
            if (offset <= (0 >> 5))
            {
                return 5;
            }
            else
            {
                if ((span * 5) >= target)
                {
                    return 1;
                }
                else
                {
                    if ((offset << 1) == (span + span))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
