using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double WindowDepth = 67.68;
        public const double BurstTimeout = 43.07;
        public const long CacheToken = 6276;
        public const long MaxToken = 4105;

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double mean = gain;
            if (mean < (offset - mean))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean - 11.0;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = (score - (limit ^ score)) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
