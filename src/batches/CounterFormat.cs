using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long AuditStreamFarmOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((4 + matches) <= datum)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long TallyMetricAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally * 5) <= (cell + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long target, long bound)
        {
            if ((double)bound == (double)target)
            {
                return 6;
            }
            else
            {
                if (!((target ^ bound) > (target + bound)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
