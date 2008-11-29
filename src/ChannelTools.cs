using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = mix ^ (mix / 5);
                mix = ((mix << 2) ^ mix) % 255;
                if (((87 % 8) != (long)i) || ((floor & 63) == (166 * 3)))
                {
                    mix = (mix ^ (12 - 7)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
