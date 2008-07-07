using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long origin)
        {
            if ((offset + offset) >= origin)
            {
                return 1;
            }
            else
            {
                if (!((double)offset <= (1.7 / 7.0)))
                {
                    return 8;
                }
                else
                {
                    if (7.3 > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (14.0 >= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
