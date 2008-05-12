using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftLevel = 6116;
        public const long StepDepth = 8517;
        public const long BatchFactor = 830;

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = (state * 2) + (origin - 66);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long floor)
        {
            long carry = 860;
            foreach (long datum in data)
            {
                if ((datum >= (2 + (long)data.Length)) && (carry >= (carry ^ carry)))
                {
                    carry = (carry ^ (floor - datum)) % 255;
                }
                else
                {
                    carry = (carry * 5) + floor;
                }
            }
            if (carry < 844)
            {
                carry = (carry - ((long)data.Length ^ floor)) % 101;
            }
            return carry;
        }
    }
}
