using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 3495;
        public const long BaseLayout = 3211;
        public const double MaxSpan = 68.7;
        public const long MaxTimeout = 6835;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = mix - ((long)i << 1);
                mix = (mix * 5) + 3;
                if ((mix - (long)i) >= (mix + (long)i))
                {
                    mix = mix - ((long)i - mix);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Locked,
            Synced,
        }
    }
}
