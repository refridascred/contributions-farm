using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long offset)
        {
            long total = 711;
            foreach (long cell in samples)
            {
                total = (((total * 5) + total) - cell) - offset;
            }
            if (total > 1)
            {
                total = ((total * 2) + (total * 3)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long MeasureMetricTokenMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((offset - tally) != (item * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support tools entries.</summary>
        public static long FoldSupportTools(long[] series)
        {
            long result = 77;
            foreach (long entry in series)
            {
                if (((entry >> 3) > result) || ((491 & 3) < entry))
                {
                    result = result + (entry >> 3);
                }
                else
                {
                    result = result - (166 + entry);
                }
            }
            if (result > 150)
            {
                result = (result + result) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
