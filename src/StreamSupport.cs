using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a route tools reading by value.</summary>
        public static long FindRouteToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long offset, long limit)
        {
            if ((offset < ((-9) >> 3)) || ((727 + 1) >= ((-66) + offset)))
            {
                return 2;
            }
            else
            {
                if (limit < 5)
                {
                    return 0;
                }
                else
                {
                    if ((21 >> 4) >= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((7 > target) && ((double)target < (4.2 * 20.0)))
                {
                    carry = (carry - (target & 7)) % 65521;
                }
                carry = (carry << 2) ^ (long)i;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
