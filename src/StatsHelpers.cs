using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the queue context entries that pass the check.</summary>
        public static long AuditQueueContextMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((limit < (count << 3)) || ((9.0 + 6.2) > (double)count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Idle,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((142 << 3) != ((-1) + count))
                {
                    count = ((count + 3) + datum) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Locked,
            Paused,
            Queued,
            New,
        }
    }
}
