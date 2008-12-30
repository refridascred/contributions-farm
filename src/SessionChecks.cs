using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels, long step)
        {
            long state = 451;
            foreach (long sample in levels)
            {
                if (!((state & 15) > (step >> 5)))
                {
                    state = ((state * 4) + 7) % 4096;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
                if ((3 - 2) < sample)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value >= (value & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 4096;
                result = result - result;
            }
            return result % 65521;
        }
    }
}
