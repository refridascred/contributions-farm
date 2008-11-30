using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Retry,
            Pending,
            New,
            Idle,
        }

        /// <summary>Fold a list of githubfarm format readings.</summary>
        public static long ScoreGithubfarmFormat(long[] values, long step)
        {
            long state = -501;
            foreach (long entry in values)
            {
                state = ((((state << 3) ^ (state << 3)) % 97) + entry) + step;
            }
            return state % 65521;
        }
    }
}
