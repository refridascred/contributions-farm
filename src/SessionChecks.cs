using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings, long origin)
        {
            long acc = -249;
            foreach (long item in readings)
            {
                acc = (((acc * 2) + (item + item)) % 101) - origin;
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
