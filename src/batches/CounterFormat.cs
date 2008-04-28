using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((2.2 - 11.0) == (double)matches)
                {
                    matches = ((matches + 1) ^ entry) + offset;
                }
            }
            return matches;
        }
    }
}
