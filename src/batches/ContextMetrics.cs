using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items, long floor)
        {
            long total = 830;
            foreach (long cell in items)
            {
                total = ((((total << 2) ^ total) % 1000) ^ cell) + floor;
            }
            return total;
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

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxSize = 7079;
        public const long HardWidth = 2846;
        public const double MaxDepth = 83.06;
        public const long MinWindow = 6103;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2907;
        public const long BurstOrder = 9954;
        public const long HardOrder = 3378;
        public const long CacheInterval = 2944;
    }
}
