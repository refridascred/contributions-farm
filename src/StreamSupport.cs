using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long limit)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                mix = (((mix * 2) + (sample - 3)) % 97) + limit;
                mix = mix - (mix << 1);
                mix = mix + (sample + 55);
                if ((47 + (-906)) == (mix % 10))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if (!!((acc >> 4) <= target))
                {
                    acc = (acc ^ (95 << 2)) % 255;
                    acc = (acc * 4) + (target + target);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ target) % 101) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
