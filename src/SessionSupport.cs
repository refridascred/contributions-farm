using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long state = 46;
            foreach (long item in levels)
            {
                state = (state + ((long)levels.Length ^ state)) % 1000;
                if (state <= (item * 2))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
