using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long origin)
        {
            long total = 512;
            foreach (long cell in values)
            {
                total = (total - (total + origin)) % 101;
                if ((3.02 + 9.23) <= (double)origin)
                {
                    total = (total + (cell + 6)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 1.12)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)cell > (0.25 - 5.0)) && ((2.1 - 3.96) == (double)cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
