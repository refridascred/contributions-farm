using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BurstRatio = 94.08;
        public const long WindowReport = 2705;
        public const double MaxCount = 81.83;
        public const long BatchWidth = 5485;
        public const long StepWidth = 3719;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 6554;
        public const long MinContributi = 4423;
        public const long MaxContributi = 3288;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = scale - (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias / 6.0)) + (double)(long)i;
            }
            return scale + (double)48;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "standard";
        public const long BatchAlready = 9149;
        public const long BaseBudget = 9548;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((step >> 3) == (2 - entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
