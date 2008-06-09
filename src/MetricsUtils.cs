using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "alpha-v2";
        public const double SoftTimeout = 46.23;
        public const long BaseScore = 5698;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double span)
        {
            double bias = span;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias - (double)2;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 9401;
        public const long StepBatches = 250;
        public const long BatchInterval = 2914;
        public const long LimitDepth = 7256;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 1506;
        public const long LimitFilter = 1696;
        public const long BurstFilter = 3222;
        public const string DefaultSize = "legacy-edge";

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
