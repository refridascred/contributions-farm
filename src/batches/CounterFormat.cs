using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 3.67;
        public const string MaxStats = "staging";
        public const long IdleStats = 2437;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((carry + step) <= carry))
                {
                    carry = (carry ^ (645 + step)) % 101;
                }
                carry = carry + (585 + step);
                if (((step & 31) != (carry - 33)) || ((long)i < step))
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next cluster entry value from a seed.</summary>
        public static long IterateClusterEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (((state * 3) + 322) % 1000) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
