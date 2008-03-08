using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long target)
        {
            long state = 373;
            foreach (long value in series)
            {
                state = (state ^ (target % 24)) + value;
            }
            return state;
        }

        /// <summary>Audit queue commits readings against a rule.</summary>
        public static long AuditQueueCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count % 24) != (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
