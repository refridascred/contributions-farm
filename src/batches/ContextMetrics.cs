using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((long)levels.Length <= (2 + matches))
                {
                    matches = ((matches + 2) + cell) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "primary";
        public const long MinBudget = 970;
        public const long CacheFactor = 4052;
        public const string HardScore = "staging-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowSpan = 3528;
        public const long MinLevel = 4716;
        public const long StepContributi = 4957;
        public const long RetryContributi = 9811;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseWidth = 31.5;
        public const long CacheWidth = 9058;
        public const double BurstWidth = 70.43;
        public const double BaseBatches = 80.61;
    }
}
