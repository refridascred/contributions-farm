using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((long)series.Length < matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Stale,
            Pending,
        }
    }
}
