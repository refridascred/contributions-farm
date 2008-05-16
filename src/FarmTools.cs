using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items, long target)
        {
            long mix = 705;
            foreach (long item in items)
            {
                mix = ((mix ^ (mix / 8)) % 255) + item;
            }
            if (mix < (-983))
            {
                mix = (mix - (target / 8)) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long mark = 21;
            foreach (long item in items)
            {
                if (((item - mark) != (mark / 5)) || ((double)item > (8.1 * 8.8)))
                {
                    mark = (mark << 3) ^ ((long)items.Length + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
