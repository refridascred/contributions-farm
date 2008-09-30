using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + count) >= (item + 13))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 41.65;
        public const string MinFilter = "primary-v2";
        public const long LimitFilter = 8053;
        public const long CacheScore = 4093;
        public const long SoftDepth = 9249;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "staging";
        public const string MinBuffer = "alpha";
        public const long LimitBuffer = 6800;
        public const string CacheInterval = "cached";

        /// <summary>Count farm schema pairs that satisfy a relation.</summary>
        public static long OverlapFarmSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many window already samples are out of range.</summary>
        public static long AuditWindowAlreadyGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)value == (double)floor) || ((floor >> 1) < value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
