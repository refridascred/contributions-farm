using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next support stream value from a seed.</summary>
        public static long SeriesSupportStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (mix + (long)i)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix * 5) + origin) % 101) ^ (long)i2;
                    mix = ((mix * 3) + origin) % 255;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 86.56;
        public const double SoftMetric = 82.36;
        public const long HardDepth = 5299;
    }
}
