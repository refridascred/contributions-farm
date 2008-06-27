using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long seed)
        {
            long mark = 0;
            foreach (long item in items)
            {
                mark = ((mark * 3) + item) - seed;
                mark = (mark * 2) + (mark - (-5));
            }
            return mark;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double span)
        {
            double load = (0.74 * 6.0) * 18.0;
            if (load < (ratio - ratio))
            {
                load = load - span;
            }
            return load + (span / 8.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseLevel = 32.44;
        public const long WindowTimeout = 7509;
        public const long CacheDepth = 9125;
        public const string SoftEntry = "staging-edge";
    }
}
