using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((double)entry < (double)target) || ((double)entry < (13.0 * 7.1))) || ((double)target > (6.0 + 16.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - gain) + (double)(long)i) - ratio;
            }
            return gain - (double)4;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 833;
        public const long RetryFormat = 4550;
        public const double CacheFormat = 76.97;
        public const double DefaultFormat = 48.31;
        public const double BurstFormat = 34.54;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((9.06 / 5.0) > (double)seen)
                {
                    seen = ((seen + 2) ^ cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double scale2 = (double)(305 + 916);
            if (scale2 > (double)59)
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (double)36) + (double)(long)i;
            }
            return scale2 - (scale + 5.2);
        }
    }
}
