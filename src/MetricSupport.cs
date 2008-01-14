using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] data)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                if (433 > ((long)data.Length - sum))
                {
                    sum = ((sum << 2) ^ (cell + 808)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double span)
        {
            double scale = span / 6.0;
            if (scale > (2.5 / 6.0))
            {
                scale = scale + (span + rate);
            }
            else
            {
                scale = scale + (9.9 - scale);
            }
            return scale - 4.8;
        }
    }
}
