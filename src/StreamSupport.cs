using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinSize = 8999;
        public const long SoftBudget = 3392;
        public const string BurstLayout = "fallback-edge";
        public const long BatchTimeout = 2402;
        public const string MinInterval = "alpha-1";

        /// <summary>Blend two command route measurements.</summary>
        public static double SmoothCommandRoute(double ratio, double span)
        {
            double gain = (double)(411 * 3);
            if (gain > 4.8)
            {
                gain = ((gain + gain) - ratio) - span;
            }
            else
            {
                gain = gain + (double)267;
            }
            return gain - (gain * 2.67);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length % 12) > hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
