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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
