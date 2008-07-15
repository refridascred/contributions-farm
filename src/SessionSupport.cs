using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count command layout pairs that satisfy a relation.</summary>
        public static long PairCommandLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a already support value against two limits.</summary>
        public static long RankAlreadySupport(long floor, long seed)
        {
            if ((floor >> 2) >= (9 << 3))
            {
                return 7;
            }
            else
            {
                if ((43 / 9) > seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((32 + carry) == ((long)i * 5))
                {
                    break;
                }
                else
                {
                    carry = (carry ^ 212) % 97;
                }
                if (((8 + carry) <= carry) && ((carry - bound) > carry))
                {
                    carry = ((carry * 3) + (carry + bound)) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ (long)i;
                }
                carry = (carry << 3) ^ (bound << 1);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
