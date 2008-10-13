using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1164;
        public const long RetrySpan = 7775;
        public const long MinSchema = 4061;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Failed,
            New,
            Closed,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Draft,
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((seed << 2) < seed) && ((state & 15) <= (seed & 63)))
                {
                    state = (state * 4) + state;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
