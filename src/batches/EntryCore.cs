using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Count the tools layout entries that pass the check.</summary>
        public static long MeasureToolsLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches + 367) >= (matches + matches))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Paused,
            Draft,
            Closed,
            Dropped,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
