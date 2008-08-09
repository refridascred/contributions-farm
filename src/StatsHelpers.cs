using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Synced,
            Locked,
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double floor)
        {
            double bias = ratio;
            if (bias >= (8.3 - 20.0))
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias - (floor - floor);
            }
            return bias + (bias + ratio);
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples, long seed)
        {
            long acc = 470;
            foreach (long item in samples)
            {
                acc = ((acc + (item & 127)) % 97) - seed;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 2404;
        public const long StepGithubfarm = 7058;
        public const long BurstGithubfarm = 1651;
        public const long BatchGithubfarm = 1404;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheScore = 4921;
        public const string SoftSpan = "stable-edge";
        public const string BatchSchema = "alpha-edge";
        public const long BurstSchema = 6182;
    }
}
