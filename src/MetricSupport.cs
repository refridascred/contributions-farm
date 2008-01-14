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

        /// <summary>Digest a series of profile format entries.</summary>
        public static long CombineProfileFormat(long[] readings)
        {
            long score = 61;
            foreach (long reading in readings)
            {
                score = score ^ (reading / 4);
            }
            return score;
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
