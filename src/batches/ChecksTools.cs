using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "fallback";
        public const string SoftRatio = "local";
        public const string HardAlready = "standard";
        public const long MaxAlready = 9028;
        public const string IdleAlready = "latest-edge";

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double span)
        {
            double scale = span;
            if (scale < (double)1)
            {
                scale = scale + 7.5;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (9.2 * 3.0)) + (double)(long)i;
            }
            return scale - ratio;
        }
    }
}
