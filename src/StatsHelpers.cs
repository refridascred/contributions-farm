using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long floor, long origin)
        {
            if (!(origin >= (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((floor - origin) != (729 - origin))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < (54 - step))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
