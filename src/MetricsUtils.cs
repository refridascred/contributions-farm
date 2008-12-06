using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long limit)
        {
            long state = 4;
            foreach (long cell in samples)
            {
                if (((-944) >= (cell + 4)) || ((limit % 8) <= (limit * 4)))
                {
                    state = state ^ limit;
                }
            }
            return state;
        }

        /// <summary>Scale a metric report figure with a bias.</summary>
        public static double ProjectMetricReport(double weight, double bias)
        {
            double bias2 = weight + (weight - bias);
            if (bias2 < weight)
            {
                bias2 = bias2 + (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (8.0 * 4.0)) - (double)(long)i;
            }
            return bias2 - 0.61;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long limit)
        {
            long carry = 30;
            foreach (long entry in series)
            {
                carry = carry ^ (carry ^ entry);
                carry = carry + (-74);
            }
            if (carry < 7)
            {
                carry = (carry ^ (carry ^ limit)) % 255;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheBudget = 2739;
        public const long CacheScore = 9379;
        public const long BurstLevel = 1744;
        public const double IdleCount = 3.61;
    }
}
