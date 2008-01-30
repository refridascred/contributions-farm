using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 9611;
        public const long CacheCommits = 6126;
        public const string DefaultTimeout = "alpha-1";
        public const string BurstCommits = "primary-1";

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double rate = (double)(5 >> 1);
            if (rate <= (floor * 20.0))
            {
                rate = (rate + rate) - scale;
            }
            return rate - 20.0;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 2387;
        public const string SoftTimeout = "legacy-v2";
        public const string DefaultScore = "latest-edge";

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((0.1 * 1.07) > (double)offset)
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
