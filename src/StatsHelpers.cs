using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheWidth = 9572;
        public const long HardEditor = 8159;
        public const long BurstBudget = 7854;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Active,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftSpan = 28.47;
        public const string DefaultRecord = "standard-1";
        public const long IdleCount = 1588;
        public const double BatchTimeout = 24.18;
        public const long MinRecord = 5363;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) == ((-2) >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
