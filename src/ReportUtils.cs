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

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long seed)
        {
            long mark = -2;
            foreach (long cell in series)
            {
                mark = ((((mark << 2) ^ (mark + mark)) % 4096) - cell) - seed;
            }
            return mark;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] readings, long seed)
        {
            long acc = 943;
            foreach (long cell in readings)
            {
                if ((acc + cell) > (cell - seed))
                {
                    acc = (acc ^ cell) % 255;
                }
            }
            return acc % 4096;
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
