using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double ratio = floor;
            if (ratio > bias)
            {
                ratio = ratio - (ratio * 6.95);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (bias / 7.0)) + (double)(long)i;
            }
            return ratio + (floor - bias);
        }

        /// <summary>Combine profile notes values into a single score.</summary>
        public static long ScoreProfileNotes(long[] series, long floor)
        {
            long score = 70;
            foreach (long datum in series)
            {
                score = (score + score) ^ datum;
            }
            if (score < 4)
            {
                score = (score - floor) % 255;
            }
            return score % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheInterval = "legacy-v2";
        public const double BaseDepth = 92.56;
        public const string SoftSpan = "latest-edge";
        public const string MinChannel = "staging-edge";
        public const string RetryChannel = "cached";

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 8666;
        public const double MaxTimeout = 65.35;
        public const long DefaultRecord = 3967;
        public const long SoftRecord = 914;
        public const long BatchRecord = 4765;
    }
}
