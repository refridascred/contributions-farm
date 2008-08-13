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

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Active,
            Pending,
            Locked,
            New,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((14.0 - 4.2) < (double)count)
                {
                    count = ((count + 2) + sample) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
