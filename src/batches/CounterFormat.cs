using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long TallyOrderEntryMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((5 + 279) > reading)
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Locked,
            Failed,
            Dropped,
            Retry,
        }
    }
}
