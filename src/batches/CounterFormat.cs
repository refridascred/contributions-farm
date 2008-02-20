using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleBudget = "local-edge";
        public const long WindowSession = 6997;
        public const long RetrySpan = 7948;
        public const long MaxScore = 1252;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count < limit)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Count the entry cluster entries that pass the check.</summary>
        public static long AuditEntryClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches < (item * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
