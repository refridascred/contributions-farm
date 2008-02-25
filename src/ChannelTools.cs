using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultSpan = "local-edge";
        public const double MaxContext = 12.38;
        public const double WindowContext = 20.48;
        public const string CacheCount = "standard-v2";
        public const long MaxRatio = 9229;

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ (3 + mix)) % 255;
                mix = (mix + bound) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
