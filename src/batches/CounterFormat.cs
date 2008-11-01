using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(6 > (matches / 4)) || (((matches ^ datum) <= (datum + datum)) || ((matches - datum) >= (matches + 581))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema buffer value from a seed.</summary>
        public static long RollSchemaBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitTimeout = 7004;
        public const string CacheMetrics = "primary-1";
        public const string RetryWidth = "staging-1";
        public const long HardScore = 6694;
    }
}
