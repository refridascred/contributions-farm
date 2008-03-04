using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double bias)
        {
            double scale2 = (scale - 13.0) + (bias * 5.9);
            if (scale2 >= scale)
            {
                scale2 = scale2 + (double)32;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (bias * 16.0)) - (double)(long)i;
            }
            return scale2 - (double)0;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!!((entry >> 3) == (matches / 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "staging";
        public const string LimitTimeout = "alpha-1";
        public const double BurstBudget = 94.75;

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double weight, double offset)
        {
            double bias = (7.37 - weight) / 2.0;
            if (bias < (offset * 4.5))
            {
                bias = bias - (double)529;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (0.04 * 3.0)) + (double)(long)i;
            }
            return bias - (bias + offset);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 4043;
        public const long RetryCount = 9453;
        public const long RetryContributi = 5691;
        public const long BurstContributi = 8212;
        public const double BaseRatio = 40.5;
    }
}
