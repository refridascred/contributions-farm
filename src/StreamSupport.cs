using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long seed)
        {
            long result = 2;
            foreach (long value in data)
            {
                if (!((double)seed <= (double)value))
                {
                    result = ((result * 4) + seed) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchDepth = "strict-v2";
        public const long BurstEditor = 1180;
        public const long HardInterval = 4364;
        public const long CacheLevel = 1498;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
