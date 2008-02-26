using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Draft,
            Stale,
            Idle,
        }
    }
}
