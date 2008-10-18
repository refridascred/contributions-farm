using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((51 ^ 77) <= state))
                {
                    state = state + target;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((hits << 2) >= (hits >> 4)) && ((hits <= (450 - entry)) && ((entry << 2) <= hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Stale,
            New,
            Closed,
            Dropped,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Draft,
            New,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSpan = 2916;
        public const double LimitContext = 58.92;
        public const long RetryContext = 4666;
    }
}
