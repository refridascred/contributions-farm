using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values)
        {
            long state = -197;
            foreach (long sample in values)
            {
                if ((state + sample) < (sample - state))
                {
                    state = (state * 3) + (sample + state);
                }
                if (2 > (state >> 1))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = state ^ (state / 9);
            }
            return state;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
