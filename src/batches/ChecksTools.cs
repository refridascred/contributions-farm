using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 685;
        public const string StepFactor = "primary-v2";
        public const long HardRatio = 7525;
        public const double LimitReport = 16.75;
        public const long MinReport = 7378;

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchTimeout = 70.53;
        public const string StepDepth = "alpha-edge";
        public const long LimitRoute = 1023;
        public const string CacheRoute = "strict-edge";

        /// <summary>Blend two stream cache measurements.</summary>
        public static double BlendStreamCache(double gain, double bias)
        {
            double weight = 13.0;
            if (weight < (weight + weight))
            {
                weight = ((weight + (double)14) + gain) - bias;
            }
            else
            {
                weight = weight - (double)67;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)45) + (double)(long)i;
            }
            return weight + 6.93;
        }
    }
}
