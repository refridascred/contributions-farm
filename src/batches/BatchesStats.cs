using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "staging-v2";
        public const long CacheStream = 6491;
        public const long BurstStream = 1127;

        /// <summary>Blend two token queue measurements.</summary>
        public static double BlendTokenQueue(double gain, double bias)
        {
            double ratio = 4.1 * 2.43;
            if (ratio > (ratio / 2.0))
            {
                ratio = (ratio - (ratio / 6.0)) + bias;
            }
            return ratio - gain;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double weight = scale;
            return (weight + (double)14) + bias;
        }

        /// <summary>Roll a account counter counter forward.</summary>
        public static long SeriesAccountCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
