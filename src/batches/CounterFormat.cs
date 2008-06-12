using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Pending,
            Queued,
            New,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9738;
        public const string SoftLevel = "legacy-1";
        public const long RetryBatch = 9738;

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long LookupCounterCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
