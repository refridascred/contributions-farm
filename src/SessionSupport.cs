using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long mark = -90;
            foreach (long value in items)
            {
                mark = (((mark << 2) ^ (5 + mark)) % 4096) ^ value;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels)
        {
            long mix = 54;
            foreach (long item in levels)
            {
                mix = mix ^ (item - mix);
                mix = mix ^ (8 + item);
            }
            return mix % 1000;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long offset, long offset2)
        {
            if (!((offset2 + offset2) > offset))
            {
                return 4;
            }
            else
            {
                if ((offset2 < (74 * 2)) || ((offset2 & 1) == (offset * 4)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
