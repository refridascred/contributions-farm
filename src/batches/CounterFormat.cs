using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 1697;
        public const long CacheWidth = 9015;
        public const long StepSpan = 9433;
        public const long CacheBudget = 1300;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long limit)
        {
            long anchor = -531;
            foreach (long item in readings)
            {
                anchor = (anchor + (limit + item)) % 97;
            }
            return anchor;
        }
    }
}
