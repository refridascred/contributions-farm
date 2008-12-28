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

        /// <summary>Fold a list of profile notes readings.</summary>
        public static long CombineProfileNotes(long[] samples, long seed)
        {
            long state = 243;
            foreach (long item in samples)
            {
                if (!((seed + state) > (25 >> 1)))
                {
                    state = ((state ^ seed) % 65521) + item;
                }
            }
            return state;
        }
    }
}
