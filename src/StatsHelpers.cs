using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the channel payload series from a seed.</summary>
        public static long RollChannelPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = carry - ((long)i << 1);
                if ((((-53) ^ carry) > origin) && ((carry & 255) <= carry))
                {
                    carry = (carry + (carry / 4)) % 101;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((acc ^ bound) <= (627 + 27))
                {
                    acc = (acc + bound) % 4096;
                    acc = ((acc * 5) + (acc % 2)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((carry >> 1) > 36)
                {
                    carry = ((carry * 2) + (carry - 20)) % 4096;
                }
                carry = carry ^ (carry + origin);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank graph schema input into a small class.</summary>
        public static long GradeGraphSchema(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((offset >> 2) < (seed << 1))
            {
                return 0;
            }
            else
            {
                if (5.6 <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((bound - 91) <= offset) || ((bound / 6) > (offset << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
