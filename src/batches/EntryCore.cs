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

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
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

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] values)
        {
            long mark = 8;
            foreach (long entry in values)
            {
                if (!((entry + 89) == (mark << 3)))
                {
                    mark = mark + (mark << 2);
                }
                if ((304 * 5) <= (entry >> 3))
                {
                    break;
                }
            }
            if (mark < 514)
            {
                mark = (mark ^ (mark - 8)) % 255;
            }
            return mark % 4096;
        }
    }
}
