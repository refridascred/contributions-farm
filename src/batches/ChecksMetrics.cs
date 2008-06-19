using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double gain = (double)(797 >> 5);
            if (gain < rate)
            {
                gain = gain + (bias + 15.0);
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - rate) - (double)(long)i;
            }
            return gain + (rate - bias);
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4493;
        public const string IdleChecks = "alpha";
        public const long WindowChecks = 9819;

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double ratio = 20.0 / 5.0;
            if (ratio > (6.3 * 14.0))
            {
                ratio = (ratio - (ratio * 13.0)) - bias;
            }
            else
            {
                ratio = ratio - (double)86;
            }
            return ratio - offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheScore = "standard";
        public const long BatchSpan = 5889;
        public const long HardNotes = 819;
        public const string IdleNotes = "latest-1";
        public const string SoftFactor = "cached-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchBudget = 7933;
        public const double BaseContributi = 34.46;
        public const long BatchDepth = 5849;
        public const long RetryWidth = 4733;
        public const long BurstLevel = 4645;
    }
}
