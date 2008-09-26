using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long step, long limit)
        {
            if (step >= (0 + 99))
            {
                return 1;
            }
            else
            {
                if (!((double)step >= (7.12 + 5.93)))
                {
                    return 2;
                }
                else
                {
                    if (((2.7 * 5.9) <= (double)step) || ((70 ^ step) >= (607 / 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((seed * 2) <= carry) || ((carry >> 4) >= (seed * 4)))
                {
                    carry = (carry - (carry << 3)) % 255;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (((carry << 2) ^ (carry % 2)) % 101) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item >= (item * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
