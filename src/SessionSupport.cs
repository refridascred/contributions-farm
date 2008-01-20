using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "open-v2";
        public const long IdleBudget = 861;
        public const string StepFactor = "strict";

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples)
        {
            long state = 4;
            foreach (long value in samples)
            {
                if ((double)state >= (7.6 + 7.9))
                {
                    state = (state ^ (state - state)) % 4096;
                }
                if ((state & 15) > (value + value))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ carry) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
