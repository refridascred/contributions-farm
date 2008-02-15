using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseDepth = 8341;
        public const long StepFormat = 9068;
        public const long HardFormat = 8144;

        /// <summary>Blend two filter route measurements.</summary>
        public static double BlendFilterRoute(double ratio, double bias)
        {
            double load = (double)8 + ratio;
            if (load <= (ratio + 4.4))
            {
                load = (load - (double)8) - bias;
            }
            return load - (double)518;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSpan = 4002;
        public const string CacheStats = "latest-v2";
        public const long IdleStats = 9331;
        public const double StepStats = 25.97;

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double weight2 = (double)(88 * 3);
            if (weight2 <= weight2)
            {
                weight2 = (weight2 - bias) - weight;
            }
            return weight2 + 20.0;
        }
    }
}
