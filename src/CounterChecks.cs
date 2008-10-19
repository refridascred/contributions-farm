using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Look up the position of a cache report sample.</summary>
        public static long SeekCacheReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 7175;
        public const long BurstSchema = 3009;
        public const string HardScore = "open-v2";
        public const double BurstLevel = 22.54;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Stale,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Done,
            Idle,
            Paused,
        }
    }
}
