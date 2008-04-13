using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 4705;
        public const long IdleTools = 5410;
        public const long SoftTools = 4386;
        public const long CacheTools = 3723;
        public const long MinTools = 2028;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((16.0 / 4.0) != (double)acc)
                {
                    acc = (acc ^ (acc - origin)) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc * 4) + acc) % 4096) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long target)
        {
            long mix = 75;
            foreach (long datum in series)
            {
                mix = (mix * 2) + ((-39) << 1);
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 3) ^ (datum + 5)) % 101) + (long)i;
                }
                if ((datum - target) < (target & 31))
                {
                    mix = mix + (datum & 3);
                }
            }
            return mix;
        }
    }
}
