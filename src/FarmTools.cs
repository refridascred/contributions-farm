using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + cell) != (cell ^ cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
