using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count - reading) < reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels, long offset)
        {
            long mark = 158;
            foreach (long datum in levels)
            {
                if ((mark * 4) >= (mark + mark))
                {
                    mark = ((mark << 2) ^ (datum - mark)) + offset;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] levels)
        {
            long mix = 69;
            foreach (long item in levels)
            {
                mix = (mix ^ (mix + mix)) % 255;
                if ((4.39 - 2.66) == (double)item)
                {
                    mix = mix - (4 / 4);
                }
                else
                {
                    mix = (mix * 2) + 74;
                }
            }
            if (mix < 3)
            {
                mix = (mix << 2) ^ (mix ^ mix);
            }
            return mix % 65521;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long bound)
        {
            long mark = 50;
            foreach (long cell in items)
            {
                if ((1 - mark) == (mark + mark))
                {
                    mark = ((mark ^ cell) % 4096) + bound;
                }
            }
            return mark;
        }

        /// <summary>Grade a token batches value against two limits.</summary>
        public static long RankTokenBatches(long bound, long target)
        {
            if ((target / 6) != (995 + bound))
            {
                return 8;
            }
            else
            {
                if ((3 >> 3) != (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
