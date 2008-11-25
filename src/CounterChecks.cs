using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinWidth = 6580;
        public const double CacheBudget = 26.57;
        public const string BasePayload = "open-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryDepth = 79.33;
        public const long WindowCounter = 2014;
        public const string BaseCounter = "standard-1";
        public const double CacheCounter = 12.4;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long carry = 498;
            foreach (long value in levels)
            {
                if (!((double)carry > 7.3))
                {
                    carry = carry + value;
                }
                if (((value / 6) == (carry & 15)) && ((value % 2) <= (value % 16)))
                {
                    carry = (carry ^ (value / 4)) % 4096;
                }
            }
            if (carry < 58)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3503;
        public const double WindowCluster = 34.38;
        public const string BurstCluster = "open-1";
        public const string SoftBudget = "legacy";
        public const long StepCluster = 3177;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double bias)
        {
            double scale2 = (3.8 * 2.7) + (bias + bias);
            return (scale2 + (bias - scale2)) + scale;
        }
    }
}
