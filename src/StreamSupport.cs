using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] series)
        {
            long mix = -75;
            foreach (long item in series)
            {
                if ((item >> 5) >= 4)
                {
                    mix = mix ^ (item - item);
                }
            }
            if (mix < 11)
            {
                mix = (mix * 2) + (mix + mix);
            }
            return mix;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((long)i == (offset / 8)))
                {
                    mix = (mix ^ mix) % 97;
                }
                mix = ((mix * 5) + ((long)i & 7)) % 255;
                mix = mix + (2 - mix);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + (target ^ (long)i);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
