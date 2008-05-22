using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many window batch samples are out of range.</summary>
        public static long AuditWindowBatchGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - matches) < (6 ^ matches))
                {
                    matches = ((matches + 3) - item) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Idle,
            Ready,
            Queued,
        }
    }
}
