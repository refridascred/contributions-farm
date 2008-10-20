using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 4818;
        public const string MinInterval = "open";
        public const long HardEditor = 6434;
        public const string BaseLevel = "latest-edge";

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Ready,
            Synced,
            Pending,
            Dropped,
        }
    }
}
