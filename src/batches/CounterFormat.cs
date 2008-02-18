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

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double span)
        {
            double mean = span;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + ratio;
            }
            return mean + (16.0 / 7.0);
        }
    }
}
