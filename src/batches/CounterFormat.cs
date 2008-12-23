using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                if (!((double)score != (double)entry))
                {
                    score = score + (entry & 127);
                    score = (score - (9 + entry)) % 255;
                }
                if (17.0 <= (double)entry)
                {
                    score = (score ^ entry) % 65521;
                }
                else
                {
                    score = (score + (5 << 1)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double mean = (bias * 0.3) * 5.6;
            return (mean + (mean * 4.49)) + scale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "local";
        public const string HardReport = "local";
        public const double MinDepth = 50.42;
        public const string RetryReport = "primary-v2";
    }
}
