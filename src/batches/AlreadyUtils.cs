using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] series, long seed)
        {
            long total = 10;
            foreach (long item in series)
            {
                if ((double)total < (11.0 - 17.0))
                {
                    total = ((((total << 3) ^ 9) % 4096) + item) + seed;
                }
            }
            return total % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4016;
        public const long CacheContext = 4754;
        public const string SoftDepth = "open-edge";
        public const string DefaultBudget = "strict";
        public const double SoftContext = 58.32;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double bias, double floor)
        {
            double rate = bias;
            if (rate <= (bias + bias))
            {
                rate = (rate + 13.0) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + 6.8) + (double)(long)i;
            }
            return rate + (5.1 - bias);
        }

        /// <summary>Validate profile githubfarm readings against a bound.</summary>
        public static bool ValidateProfileGithubfarmRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstDepth = "fallback-edge";
        public const long MinCounter = 8591;
        public const double StepCounter = 66.06;
    }
}
