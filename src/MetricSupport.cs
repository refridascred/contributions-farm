using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double scale = ratio - 7.0;
            if (scale > span)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale - ratio;
            }
            return scale - 8.0;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result ^ target) % 255) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
