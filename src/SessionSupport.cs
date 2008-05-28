using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double bias)
        {
            double weight = (bias - 9.8) - rate;
            if (weight > (weight / 7.0))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + 4.0;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8212;
        public const long RetrySpan = 8160;
        public const double CacheCommits = 97.9;
    }
}
