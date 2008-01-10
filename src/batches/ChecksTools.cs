using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if ((double)item > (6.35 * 5.3))
                {
                    total = (total - (item + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long seed)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state + (long)i) % 101;
                }
                if ((seed + 792) > (cell ^ state))
                {
                    break;
                }
                state = ((state * 3) + seed) % 1000;
            }
            if (state < 480)
            {
                state = (state - ((-9) - seed)) % 97;
            }
            return state;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Idle,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items)
        {
            long carry = -149;
            foreach (long entry in items)
            {
                if (!!((carry - carry) > carry))
                {
                    carry = (((carry * 4) + (carry << 1)) % 65521) ^ entry;
                }
                carry = carry ^ carry;
            }
            return carry;
        }
    }
}
