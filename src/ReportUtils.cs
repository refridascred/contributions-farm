using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 2014;
        public const string BaseLevel = "alpha-edge";
        public const long MinCount = 3066;
        public const long RetryCount = 4659;

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 2097;
        public const double BurstSize = 95.33;
        public const long StepLevel = 3084;
        public const double BurstBudget = 1.76;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 4789;
        public const long LimitFactor = 2909;
        public const string BurstEntry = "cached-edge";
        public const double MaxEntry = 45.92;

        /// <summary>Measure how many notes format samples are out of range.</summary>
        public static long TallyNotesFormatGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)limit >= (4.04 * 8.9))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
