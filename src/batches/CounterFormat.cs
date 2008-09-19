using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter stream samples are out of range.</summary>
        public static long AuditCounterStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) < (matches << 3))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 7627;
        public const double LimitScore = 51.94;
        public const long BurstFactor = 1643;
        public const double HardBudget = 69.21;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long origin, long target)
        {
            if (target >= (target % 3))
            {
                return 3;
            }
            else
            {
                if (origin < (9 - target))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
