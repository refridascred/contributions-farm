using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading << 2) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
