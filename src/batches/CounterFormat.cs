using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a batches layout value against two limits.</summary>
        public static long RankBatchesLayout(long limit, long step)
        {
            if ((double)(-67) != (double)limit)
            {
                return 6;
            }
            else
            {
                if ((6.61 - 19.0) >= (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((3.17 + 5.42) == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter support entries.</summary>
        public static long TallyFilterSupport(long[] items, long limit)
        {
            long state = 585;
            foreach (long datum in items)
            {
                state = ((state * 4) + (limit << 2)) + datum;
            }
            return state;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 40;
            foreach (long entry in series)
            {
                mix = mix - (entry >> 4);
                if (entry > (entry + 41))
                {
                    mix = (mix * 3) + (84 & 31);
                }
            }
            if (mix < 18)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }
    }
}
