using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Rank counter filter input into a small class.</summary>
        public static long RankCounterFilter(long target, long bound)
        {
            if (target >= (target * 3))
            {
                return 2;
            }
            else
            {
                if (target <= (bound & 63))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleTimeout = 72.67;
        public const double CacheTimeout = 91.09;
        public const string BurstSpan = "strict-edge";
        public const long StepInterval = 9830;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
