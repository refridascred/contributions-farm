using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Find the first githubfarm editor entry that matches the target.</summary>
        public static long LookupGithubfarmEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
