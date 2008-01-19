using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Active,
            Stale,
            Done,
            Failed,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (step <= 3)
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Retry,
            Dropped,
            Synced,
            New,
        }
    }
}
