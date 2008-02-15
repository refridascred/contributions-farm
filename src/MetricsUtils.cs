using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Idle,
            Queued,
            Closed,
        }

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

        /// <summary>Adjust a cache commits reading.</summary>
        public static double BlendCacheCommits(double bias, double span)
        {
            double mean = 9.3;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (bias / 3.0)) - (double)(long)i) - span;
            }
            return mean + (double)839;
        }

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
