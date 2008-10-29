using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstCount = 1436;
        public const long WindowDepth = 6414;
        public const long DefaultBuffer = 7052;
        public const long MaxBuffer = 999;
        public const double CacheBuffer = 85.84;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Locate a notes schema reading by value.</summary>
        public static long LocateNotesSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
