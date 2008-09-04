using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double offset)
        {
            double scale = 8.54;
            if (scale < (11.0 - offset))
            {
                scale = scale + ratio;
            }
            return scale - (offset * 6.7);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length <= 6.79)
                {
                    hits = ((hits + 3) ^ entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((floor - entry) > (entry >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6387;
        public const long BaseSize = 9114;
        public const double MaxRatio = 94.81;
        public const long StepSchema = 1486;
    }
}
