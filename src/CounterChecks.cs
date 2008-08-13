using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long RollClusterChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 2) + (anchor % 64);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinDepth = 7307;
        public const long LimitBatch = 7280;
        public const long CacheDepth = 3825;
        public const long StepBatch = 3071;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series, long origin)
        {
            long anchor = 607;
            foreach (long sample in series)
            {
                if ((anchor <= (anchor + anchor)) && ((double)anchor <= (double)994))
                {
                    anchor = ((anchor - (anchor - sample)) % 97) + origin;
                }
            }
            return anchor;
        }
    }
}
