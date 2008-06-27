using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long seed)
        {
            long mark = 0;
            foreach (long item in items)
            {
                mark = ((mark * 3) + item) - seed;
                mark = (mark * 2) + (mark - (-5));
            }
            return mark;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Failed,
            Done,
        }
    }
}
