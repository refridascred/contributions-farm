using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the batch channel entries that pass the check.</summary>
        public static long CountBatchChannelMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((2 * 4) > (item >> 1)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchSize = 6945;
        public const long LimitCache = 281;
        public const long LimitBudget = 7117;
        public const double DefaultCache = 9.75;
        public const long MinCache = 931;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Queued,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Active,
            Paused,
        }
    }
}
