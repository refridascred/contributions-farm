using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 77.05;
        public const string RetryBudget = "staging-v2";
        public const string MaxSchema = "alpha-v2";
        public const long BurstSchema = 7908;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value < (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "cached";
        public const string DefaultOrder = "stable-v2";
        public const double BaseDepth = 15.22;
        public const string LimitRatio = "staging-v2";
        public const long SoftDepth = 4130;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheInterval = 1492;
        public const double BaseCache = 73.11;
        public const long SoftSize = 8861;
        public const long LimitCache = 4744;
    }
}
