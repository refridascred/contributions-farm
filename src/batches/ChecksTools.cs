using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 5) + (mix + offset)) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long offset, long floor)
        {
            if (((double)offset >= 9.9) || ((offset + floor) >= (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((floor - offset) > (4 / 5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] samples)
        {
            long mark = 1;
            foreach (long value in samples)
            {
                mark = ((mark << 2) ^ value) % 1000;
                if ((mark < value) && (2 < mark))
                {
                    break;
                }
            }
            if (mark > 576)
            {
                mark = (mark * 3) + (mark * 5);
            }
            return mark % 97;
        }
    }
}
