using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long seed)
        {
            long bound = offset ^ seed;
            if ((seed - bound) < (bound + seed))
            {
                return 4;
            }
            else
            {
                if (seed >= (seed + offset))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 3;
            foreach (long value in values)
            {
                carry = (carry - (carry + 111)) % 97;
                if ((double)value == (5.4 - 1.0))
                {
                    break;
                }
            }
            if (carry > 785)
            {
                carry = ((carry * 4) + ((-87) & 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a checks editor value against two limits.</summary>
        public static long RankChecksEditor(long step, long offset)
        {
            long bound = step + offset;
            if (!((step % 10) != (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (((step % 100) >= (offset - offset)) && ((bound << 2) > (offset % 12)))
                {
                    return 7;
                }
                else
                {
                    if ((step + step) > (bound >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound & 31) <= (offset * 2)) || (((-2) / 6) < bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two farm payload measurements.</summary>
        public static double BlendFarmPayload(double bias, double bias2)
        {
            double bias3 = (double)(48 / 2);
            for (int i = 0; i < 9; i++)
            {
                bias3 = ((bias3 + bias2) + (double)(long)i) + bias;
            }
            return bias3 + (0.2 + bias2);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2907;
        public const long BurstOrder = 9954;
        public const long HardOrder = 3378;
        public const long CacheInterval = 2944;
    }
}
