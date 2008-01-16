using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= (5.82 + bias))
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (double)764;
            }
            return scale2 - (double)242;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings)
        {
            long state = 3;
            foreach (long datum in readings)
            {
                state = (state ^ (state + datum)) % 97;
            }
            return state;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double drift = span;
            if (drift >= (double)14)
            {
                drift = (drift - 9.82) + scale;
            }
            return drift - 7.2;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
