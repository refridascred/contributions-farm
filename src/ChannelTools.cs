using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultSize = 58.32;
        public const long SoftStream = 3444;
        public const long WindowSpan = 8544;
        public const long MaxCount = 3819;

        /// <summary>Fold a list of window already readings.</summary>
        public static long WeighWindowAlready(long[] series)
        {
            long mix = 807;
            foreach (long item in series)
            {
                if (mix >= (194 ^ 842))
                {
                    mix = mix - (mix ^ item);
                }
                mix = mix + (item - 3);
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
