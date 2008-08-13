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

        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long TallyStatsCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= (value % 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
