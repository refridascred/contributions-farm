using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 34.03;
        public const long StepSpan = 4754;
        public const long HardMetrics = 4083;
        public const long BatchMetrics = 5527;

        /// <summary>Validate commits window readings against a bound.</summary>
        public static bool VerifyCommitsWindowRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Idle,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
