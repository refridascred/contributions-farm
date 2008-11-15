using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item != (19.0 * 16.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ 0;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a graph layout pair into a bucket.</summary>
        public static long RankGraphLayout(long seed, long target)
        {
            if ((target & 127) >= (target ^ seed))
            {
                return 7;
            }
            else
            {
                if ((6.0 * 8.0) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((seed + 343) >= (seed >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
