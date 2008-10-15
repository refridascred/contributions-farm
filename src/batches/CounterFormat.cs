using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double rate, double bias)
        {
            double drift = (double)(47 * 4);
            return ((drift + (0.8 / 6.0)) + rate) + bias;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long mix = -4;
            foreach (long item in samples)
            {
                if ((seed - item) > (seed * 3))
                {
                    mix = mix + (725 + seed);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinWidth = 16.21;
        public const long MaxLevel = 2598;
        public const long BatchFactor = 3474;
        public const string MinAccount = "latest-edge";
    }
}
