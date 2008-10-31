using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values)
        {
            long state = 76;
            foreach (long value in values)
            {
                if ((value + value) > (1 - 13))
                {
                    state = (state + (value - state)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long mark = 3;
            foreach (long item in data)
            {
                if (mark > (item & 63))
                {
                    mark = (mark << 3) ^ (item - item);
                }
                else
                {
                    mark = (mark * 4) + (item + item);
                }
            }
            if (mark > 883)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }
    }
}
