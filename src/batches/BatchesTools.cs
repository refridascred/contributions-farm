using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stats route readings against a rule.</summary>
        public static long MeasureStatsRouteMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (target >= (target ^ sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double bias)
        {
            double ratio = (double)3;
            if (ratio < (double)762)
            {
                ratio = (ratio + bias) + rate;
            }
            return ratio + (2.0 / 5.0);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)cell < (20.0 / 8.0)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
