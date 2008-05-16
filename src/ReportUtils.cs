using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of stats buffer entries.</summary>
        public static long CombineStatsBuffer(long[] samples, long origin)
        {
            long anchor = 46;
            foreach (long item in samples)
            {
                anchor = (((anchor - anchor) % 97) + item) + origin;
            }
            return anchor % 97;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double drift = 7.8 * 6.2;
            if (drift > (drift / 5.0))
            {
                drift = ((drift - (double)82) + scale) - span;
            }
            return drift + (double)974;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 5462;
        public const long WindowEntry = 8530;
        public const double IdleDepth = 31.76;
        public const double SoftDepth = 84.12;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
