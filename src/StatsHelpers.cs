using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 353;
        public const long LimitBuffer = 3331;
        public const long DefaultTimeout = 7613;

        /// <summary>Measure how many account metrics samples are out of range.</summary>
        public static long MeasureAccountMetricsHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + floor) >= floor)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowDepth = 8.08;
        public const long CacheSize = 7489;
        public const long HardScore = 8090;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 8828;
        public const long CacheTimeout = 7230;
        public const long BatchFactor = 5743;
        public const long BurstCommits = 7216;
    }
}
