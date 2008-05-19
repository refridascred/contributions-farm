using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a route checks counter forward.</summary>
        public static long StepRouteChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((carry - carry) >= (carry - (long)i))
                {
                    carry = carry - offset;
                    carry = carry + carry;
                }
                else
                {
                    carry = carry - (6 ^ carry);
                }
                carry = (carry ^ ((long)i ^ offset)) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 4) + target;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long floor)
        {
            long state = 428;
            foreach (long item in levels)
            {
                if (((99 - state) > ((-670) & 255)) || ((item * 3) >= (floor + item)))
                {
                    state = (state << 3) ^ floor;
                }
                state = (state * 4) + (state % 2);
                state = state + floor;
            }
            return state % 65521;
        }
    }
}
