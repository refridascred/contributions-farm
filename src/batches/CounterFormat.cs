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

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 8025;
        public const double MinEditor = 19.08;
        public const long BaseSpan = 4618;
    }
}
