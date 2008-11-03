using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 465;
        public const double DefaultTimeout = 71.02;
        public const double BurstTimeout = 41.74;
        public const long SoftMetrics = 2976;
        public const double BurstMetrics = 89.84;

        /// <summary>Iterate the channel metric series from a seed.</summary>
        public static long RollChannelMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                if (((step << 1) < (step & 63)) || ((total + total) >= (963 - total)))
                {
                    total = ((total * 4) + ((long)i * 2)) % 4096;
                }
                if (((3.0 + 9.4) > (double)total) || ((5 - step) != (step / 8)))
                {
                    total = total ^ total;
                }
                total = ((total << 2) ^ ((long)i * 3)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
