using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double rate = offset;
            if (rate < (13.0 - offset))
            {
                rate = rate + scale;
            }
            return rate + (offset * 7.0);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
