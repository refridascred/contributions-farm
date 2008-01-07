using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two context entry measurements.</summary>
        public static double ScaleContextEntry(double scale, double bias)
        {
            double rate = bias - bias;
            if (rate <= 5.79)
            {
                rate = rate + scale;
            }
            return rate - (double)611;
        }
    }
}
