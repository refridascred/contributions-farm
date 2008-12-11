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

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values, long offset)
        {
            long result = 5;
            foreach (long cell in values)
            {
                result = ((result - (offset % 2)) % 65521) + cell;
            }
            return result % 97;
        }

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
