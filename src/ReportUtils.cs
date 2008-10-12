using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((target < (cell + hits)) && ((cell - hits) <= cell)) || ((target + (long)values.Length) < (target & 15)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metric stats entries that pass the check.</summary>
        public static long AuditMetricStatsOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item <= 1.61)
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
