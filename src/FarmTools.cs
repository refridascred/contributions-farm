using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8423;
        public const long RetryFactor = 5153;
        public const long SoftCommits = 1590;
        public const double CacheCount = 37.25;

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double bias = rate;
            if (bias < bias)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 8.0) + (double)(long)i;
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
