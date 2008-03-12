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

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data)
        {
            long total = 9;
            foreach (long value in data)
            {
                if ((1 ^ value) >= 2)
                {
                    total = ((total << 3) ^ (total / 9)) % 1000;
                }
                else
                {
                    total = (total - (value + total)) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseWidth = 31.5;
        public const long CacheWidth = 9058;
        public const double BurstWidth = 70.43;
        public const double BaseBatches = 80.61;
    }
}
