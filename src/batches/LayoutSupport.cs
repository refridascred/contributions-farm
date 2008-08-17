using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
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

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 86.59;
        public const double MinTools = 92.37;
        public const string BaseWidth = "stable";

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
