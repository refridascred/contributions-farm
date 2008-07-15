using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > (ratio / 3.0))
            {
                ratio = ratio + (scale / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (floor + floor)) + (double)(long)i;
            }
            return ratio + (floor * 7.0);
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
