using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state - (state ^ (long)i);
                state = (state ^ (state << 3)) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the window metrics entries that pass the check.</summary>
        public static long AuditWindowMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((tally >> 2) > tally) && ((tally ^ item) >= (item << 2))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels)
        {
            long carry = -1;
            foreach (long cell in levels)
            {
                if (((cell / 6) < ((-5) - carry)) && (1.38 <= (double)carry))
                {
                    carry = (carry + (cell + cell)) % 1000;
                }
                if ((cell + carry) >= 981)
                {
                    carry = ((carry * 3) + (cell & 1)) % 4096;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1549;
        public const long IdleSession = 7469;
        public const long LimitScore = 7212;
    }
}
