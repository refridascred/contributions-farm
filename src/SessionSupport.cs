using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next cache layout value from a seed.</summary>
        public static long SeriesCacheLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((state % 5) <= (origin ^ (long)i))
                {
                    state = state ^ (origin ^ (long)i);
                }
                else
                {
                    state = (state + origin) % 4096;
                    state = state ^ (state - origin);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 3634;
        public const long StepBudget = 4943;
        public const string CacheScore = "local";
        public const string LimitReport = "local-edge";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Done,
            Idle,
            New,
            Synced,
        }
    }
}
