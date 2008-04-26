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

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long target, long bound)
        {
            long prev = target - bound;
            if (13.0 > (double)target)
            {
                return 7;
            }
            else
            {
                if (bound >= (prev - 364))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) >= (bound + prev))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
