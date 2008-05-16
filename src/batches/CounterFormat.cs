using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next session token value from a seed.</summary>
        public static long StepSessionToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
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
