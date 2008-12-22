using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Failed,
            Active,
            Done,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
