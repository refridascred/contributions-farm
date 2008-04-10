using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long offset)
        {
            long sum = -971;
            foreach (long value in items)
            {
                sum = (((sum << 3) ^ (5 + value)) % 65521) + offset;
            }
            return sum;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                long span = (offset & 3) + (mix >> 2);
                if (!(mix < (456 % 16)))
                {
                    mix = (mix - (span ^ mix)) % 1000;
                }
                else
                {
                    mix = mix - (long)i;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
