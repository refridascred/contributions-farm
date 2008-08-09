using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double mean = (bias * 9.25) + (double)12;
            if (mean >= (mean + bias2))
            {
                mean = mean - (double)670;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (bias * 12.0)) + (double)(long)i;
            }
            return mean - (bias2 + bias);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "alpha";
        public const long LimitGithubfarm = 5123;
        public const string CacheSpan = "stable-v2";
        public const long RetryScore = 554;
        public const string HardLevel = "staging-v2";

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

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double rate, double bias)
        {
            double rate2 = (double)(416 - 641);
            if (rate2 > bias)
            {
                rate2 = (rate2 - (6.0 + 13.0)) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (double)88) + (double)(long)i;
            }
            return rate2 + 8.7;
        }
    }
}
