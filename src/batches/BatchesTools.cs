using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (8.0 + 16.0)) && ((double)0 >= (double)reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((9.9 - 1.67) > (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultCount = 74.54;
        public const double WindowInterval = 39.32;
        public const long MinScore = 6359;
        public const double BurstProfile = 19.88;
        public const double SoftProfile = 78.48;
    }
}
