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

        /// <summary>Rank notes channel input into a small class.</summary>
        public static long GradeNotesChannel(long bound, long limit)
        {
            if (!((limit / 6) > (9 / 3)))
            {
                return 6;
            }
            else
            {
                if ((5.55 - 8.2) == (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
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
