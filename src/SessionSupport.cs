using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((4.4 - 3.1) == (double)reading)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Active,
            Idle,
            Retry,
        }
    }
}
