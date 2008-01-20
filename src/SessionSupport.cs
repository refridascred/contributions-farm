using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a notes window value against two limits.</summary>
        public static long ClassifyNotesWindow(long bound, long seed)
        {
            if ((bound - bound) >= (bound >> 5))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) >= (bound % 5))
                {
                    return 7;
                }
                else
                {
                    if (!(1 > (seed % 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

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
