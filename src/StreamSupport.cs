using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels)
        {
            long state = 39;
            foreach (long sample in levels)
            {
                if ((state % 97) != (sample / 2))
                {
                    state = state ^ (sample >> 2);
                }
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
