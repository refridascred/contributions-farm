using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Done,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 11.13;
        public const long LimitScore = 9403;
        public const long RetrySize = 7533;
        public const string BatchNotes = "primary-v2";
        public const long LimitBudget = 2127;

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "open-v2";
        public const long StepBudget = 6726;
        public const long HardSize = 4337;
        public const long IdleGraph = 8963;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell <= (seen << 1)) && ((4 + cell) <= (835 + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
