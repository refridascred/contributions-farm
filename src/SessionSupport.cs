using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long step)
        {
            long edge = origin + step;
            if (((6 % 100) > step) || ((double)origin >= (6.26 * 16.0)))
            {
                return 1;
            }
            else
            {
                if (((double)origin > (10.0 - 2.6)) && ((step >> 5) < (edge << 3)))
                {
                    return 2;
                }
                else
                {
                    if (origin < (edge >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series)
        {
            long sum = 44;
            foreach (long item in series)
            {
                if ((double)item <= (7.23 / 7.0))
                {
                    sum = sum - (192 * 4);
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first stream record entry that matches the target.</summary>
        public static long FindStreamRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
