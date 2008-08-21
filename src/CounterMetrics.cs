using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 49.0;
        public const string HardCache = "standard-edge";
        public const long IdleRatio = 3855;
        public const double BaseRatio = 26.18;

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "latest-edge";
        public const long StepDepth = 7520;
        public const long BurstNotes = 811;
        public const long CacheWidth = 4894;

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double bias2)
        {
            double weight = bias2 + (1.36 + 0.4);
            if (weight < bias2)
            {
                weight = weight - (double)474;
            }
            else
            {
                weight = weight + (bias2 + 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + 6.7;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 5526;
        public const string WindowFactor = "local";
        public const long SoftLayout = 6706;
        public const long LimitWidth = 651;
        public const long CacheLayout = 5707;
    }
}
