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

        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long CountStreamChannelHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length ^ cell) <= (count + cell))
                {
                    count = count + 2;
                }
            }
            return count;
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
