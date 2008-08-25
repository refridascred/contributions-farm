using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Queued,
            Locked,
        }
    }
}
