using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
