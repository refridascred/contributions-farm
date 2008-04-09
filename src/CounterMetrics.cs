using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long origin)
        {
            long offset = seed + origin;
            if (origin < (7 % 3))
            {
                return 7;
            }
            else
            {
                if (!(offset > (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (18.0 + 7.54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Level { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
