using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a report token counter forward.</summary>
        public static long RollReportToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4083;
        public const double CacheEntry = 85.64;
        public const double CacheCount = 17.48;
        public const long BatchEntry = 3483;
        public const string HardEntry = "cached-v2";

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
