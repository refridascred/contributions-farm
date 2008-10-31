using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double rate, double bias)
        {
            double mean = bias / 8.0;
            if (mean <= (double)941)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (bias - bias)) - (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetrySize = 64.26;
        public const string BaseTimeout = "primary-1";
        public const long LimitCount = 7713;
        public const string CacheWindow = "stable";
        public const long BatchWindow = 1323;

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitWidth = 74.27;
        public const long BaseSize = 3016;
        public const long WindowAlready = 4111;
    }
}
