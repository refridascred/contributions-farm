using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double offset)
        {
            double drift = 2.99;
            if (drift > (drift - weight))
            {
                drift = (drift + (weight / 8.0)) - offset;
            }
            return drift - (double)(-963);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values, long floor)
        {
            long mix = -4;
            foreach (long sample in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((mix + (floor - mix)) % 97) - (long)i;
                }
                if (7.0 < (double)sample)
                {
                    mix = ((mix * 3) + sample) % 4096;
                }
            }
            if (mix > 768)
            {
                mix = (mix - (mix / 6)) % 4096;
            }
            return mix;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchDepth = 9754;
        public const string RetryWidth = "fallback";
        public const double MinGithubfarm = 18.91;
        public const long HardGithubfarm = 2011;

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 66.16;
        public const double LimitFactor = 11.95;
        public const long MinRoute = 6936;
        public const long SoftRoute = 8957;
    }
}
