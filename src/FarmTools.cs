using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Retry,
            Closed,
            New,
            Pending,
        }

        /// <summary>Compare every pair of cache entry readings.</summary>
        public static long CompareCacheEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchScore = 21.31;
        public const long CacheTimeout = 2438;
        public const long CacheCount = 4757;
        public const string StepWidth = "legacy";
    }
}
