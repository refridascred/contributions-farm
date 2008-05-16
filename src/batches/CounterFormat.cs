using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long limit)
        {
            if (((double)floor >= (0.4 - 0.91)) || (limit >= (68 >> 4)))
            {
                return 2;
            }
            else
            {
                if ((double)floor != (1.12 * 5.5))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-239) + limit) >= (215 + (-7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next graph farm value from a seed.</summary>
        public static long RollGraphFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long step)
        {
            long carry = -911;
            foreach (long item in items)
            {
                if (((item - item) < (step % 7)) || (((long)items.Length + item) < (carry % 10)))
                {
                    carry = ((carry * 3) + (item - 76)) % 4096;
                }
            }
            return carry;
        }
    }
}
