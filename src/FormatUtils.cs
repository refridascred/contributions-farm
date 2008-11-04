using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next window channel value from a seed.</summary>
        public static long IterateWindowChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long TotalMetricFilter(long[] levels, long offset)
        {
            long state = 699;
            foreach (long value in levels)
            {
                if ((1 & 3) >= state)
                {
                    state = (state + (state ^ value)) - offset;
                }
                if ((5.0 + 6.0) <= (double)state)
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = ((state << 2) ^ (0 << 1)) % 255;
            }
            return state;
        }

        /// <summary>Validate token metrics readings against a bound.</summary>
        public static bool ValidateTokenMetricsRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long seed)
        {
            long diff = origin + seed;
            if ((diff > (origin + origin)) || ((seed >> 4) >= seed))
            {
                return 8;
            }
            else
            {
                if (origin < (diff / 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
