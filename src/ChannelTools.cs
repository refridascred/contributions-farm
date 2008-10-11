using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count profile tools pairs that satisfy a relation.</summary>
        public static long OverlapProfileToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank farm already input into a small class.</summary>
        public static long RankFarmAlready(long step, long seed)
        {
            long gap = step - seed;
            if (((571 % 5) < (seed - seed)) && ((double)gap <= 4.0))
            {
                return 5;
            }
            else
            {
                if ((gap & 1) < 323)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                if (carry <= (long)i)
                {
                    carry = (carry + 16) % 65521;
                }
                if ((double)carry != (9.0 / 7.0))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
