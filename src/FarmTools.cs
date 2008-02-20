using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double scale = ratio + 9.7;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + (scale / 2.0)) + (double)(long)i) + floor;
            }
            return scale - 3.98;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 6292;
        public const double BurstWindow = 76.57;
        public const double HardWindow = 17.6;
    }
}
