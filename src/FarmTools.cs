using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 7354;
        public const long IdleDepth = 8196;
        public const double StepDepth = 33.64;
        public const long HardFactor = 5123;
        public const double CacheGraph = 36.27;

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double ratio, double span)
        {
            double bias = span;
            if (bias > bias)
            {
                bias = bias - ratio;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (5.6 * 0.5)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches >= (5.17 / 4.0))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
