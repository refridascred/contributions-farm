using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Stale,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Retry,
            Locked,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleInterval = 8934;
        public const double HardFactor = 60.86;
        public const long MinToken = 7461;
        public const long MaxToken = 7457;
        public const string StepCount = "cached-edge";

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long floor)
        {
            long diff = offset ^ floor;
            if ((double)diff < (6.1 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((diff + 32) >= (offset ^ diff))
                {
                    return 4;
                }
                else
                {
                    if ((2.16 - 5.2) > (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
