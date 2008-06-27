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

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryWidth = 80.93;
        public const double CacheRatio = 14.98;
        public const double MinInterval = 98.15;
    }
}
