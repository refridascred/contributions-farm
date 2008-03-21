using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Locked,
            Closed,
            Failed,
            Queued,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
