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

        /// <summary>Accumulate token format samples.</summary>
        public static long CombineTokenFormat(long[] samples)
        {
            long anchor = 32;
            foreach (long value in samples)
            {
                anchor = ((anchor * 5) + (value + 51)) % 4096;
            }
            if (anchor > 274)
            {
                anchor = anchor + (5 - anchor);
            }
            return anchor;
        }
    }
}
