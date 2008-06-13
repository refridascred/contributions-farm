using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix - (offset & 255)) % 255) ^ (long)i2;
                }
                if (!(((mix + (long)i) < (mix << 1)) || (offset < (offset % 16))))
                {
                    mix = mix ^ (long)i;
                }
                if ((4.99 - 0.5) == (double)offset)
                {
                    mix = ((mix * 2) + (offset / 2)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples)
        {
            long mix = 55;
            foreach (long entry in samples)
            {
                mix = (mix + (32 + entry)) % 255;
                if (0 < (mix ^ entry))
                {
                    mix = ((mix * 3) + mix) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
