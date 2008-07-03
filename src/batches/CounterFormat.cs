using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a record payload value against two limits.</summary>
        public static long RankRecordPayload(long bound, long offset)
        {
            if ((0 % 60) != (90 + offset))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (18.0 - 9.0)) && (3.1 < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset % 64) < bound) && ((offset + 505) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] samples, long step)
        {
            long result = 248;
            foreach (long item in samples)
            {
                if (((4.0 + 6.92) < (double)result) && ((item << 1) == (result + item)))
                {
                    result = (result ^ (item + item)) - step;
                }
            }
            if (result < 0)
            {
                result = ((result * 2) + result) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels)
        {
            long mix = -1;
            foreach (long item in levels)
            {
                if ((14.0 * 5.0) <= (double)item)
                {
                    mix = mix ^ item;
                }
            }
            if (mix > 64)
            {
                mix = mix - (mix & 255);
            }
            return mix % 4096;
        }
    }
}
