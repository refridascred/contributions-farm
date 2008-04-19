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

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
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
