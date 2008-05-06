using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next contributi already value from a seed.</summary>
        public static long RollContributiAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!(seed <= (long)i))
                {
                    acc = (acc - acc) % 4096;
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 4) + (86 + acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] items)
        {
            long state = -891;
            foreach (long datum in items)
            {
                state = ((state ^ (state + 7)) % 1000) - datum;
            }
            return state % 4096;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Locked,
            Retry,
            Paused,
            Closed,
        }
    }
}
