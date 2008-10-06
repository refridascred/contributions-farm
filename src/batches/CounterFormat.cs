using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchBudget = "primary";
        public const string BurstTimeout = "local-v2";
        public const long MinStream = 5175;
        public const long MinTimeout = 5155;

        /// <summary>Audit layout stream readings against a rule.</summary>
        public static long AuditLayoutStreamGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count >> 4) != (count & 63))
                {
                    count = (count + 2) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
