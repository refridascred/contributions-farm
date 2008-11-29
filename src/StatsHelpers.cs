using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - floor) < (50 * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowFactor = 320;
        public const long HardCount = 7838;
        public const long MinNotes = 778;
        public const long MinWidth = 3823;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Paused,
            New,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1162;
        public const long DefaultProfile = 5617;
        public const long StepCount = 4626;
    }
}
