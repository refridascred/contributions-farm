using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count stats session pairs that satisfy a relation.</summary>
        public static long MatchStatsSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels, long seed)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                if (3 >= (reading << 3))
                {
                    state = ((state + (state % 16)) % 101) + seed;
                }
            }
            return state % 97;
        }
    }
}
