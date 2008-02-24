using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(((seed + seed) > state) || ((430 % 97) == (state % 60))))
                {
                    state = state ^ (seed + state);
                }
                if ((state - state) != (6 >> 3))
                {
                    state = (state * 4) + ((long)i & 3);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Synced,
            Pending,
        }
    }
}
