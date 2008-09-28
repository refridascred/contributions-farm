using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the channel profile entries that pass the check.</summary>
        public static long TallyChannelProfileHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((target << 2) < (item << 1)) || (((long)levels.Length << 1) >= (110 + target)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
