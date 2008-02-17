using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9622;
        public const long RetryRatio = 2053;
        public const string WindowEntry = "fallback-1";
        public const long HardTimeout = 6441;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((matches & 127) < (matches + datum)) && ((double)datum < (2.7 / 8.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long offset, long offset2)
        {
            if ((offset2 + offset) < (offset2 * 3))
            {
                return 6;
            }
            else
            {
                if ((offset2 - offset) > (offset ^ 420))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
