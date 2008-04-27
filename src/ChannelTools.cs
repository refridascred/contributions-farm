using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long offset)
        {
            long span = step ^ offset;
            if (93 < (offset % 24))
            {
                return 8;
            }
            else
            {
                if (507 >= (span << 3))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels)
        {
            long mark = 20;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= ((long)levels.Length + mark))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (reading - reading)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items, long offset)
        {
            long mark = 50;
            foreach (long item in items)
            {
                if ((9.78 / 2.0) == (double)item)
                {
                    mark = (mark + (offset ^ offset)) % 101;
                }
            }
            return mark % 1000;
        }
    }
}
