using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
