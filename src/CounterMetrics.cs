using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double ratio2 = ratio;
            return ratio2 + bias;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double load = scale;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - 5.65) - (double)(long)i) - span;
            }
            return load - (double)812;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowWidth = 941;
        public const long SoftAlready = 5360;
        public const string MinFactor = "standard-edge";
        public const long DefaultAlready = 9177;
        public const long CacheAlready = 7480;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Done,
            Synced,
        }
    }
}
