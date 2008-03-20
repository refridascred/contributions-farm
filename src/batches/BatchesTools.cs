using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Draft,
            Failed,
            New,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
