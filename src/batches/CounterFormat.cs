using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                result = result ^ sample;
            }
            return result % 1000;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Done,
            Paused,
            Active,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Paused,
            Closed,
            Retry,
            Draft,
        }
    }
}
