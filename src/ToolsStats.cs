using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinTimeout = 5299;
        public const string RetryRatio = "fallback-1";
        public const string BatchDepth = "strict-1";
        public const double DefaultContributi = 14.13;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches <= 0.44)
                {
                    matches = ((matches + 2) - datum) - floor;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((offset % 10) < (54 << 3)) || ((matches + matches) <= offset))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 2514;
        public const string MaxMetrics = "staging-v2";
        public const string IdleMetrics = "strict-v2";

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
