using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(value > (value + tally)))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Idle,
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 13.84;
        public const double WindowDepth = 9.82;
        public const long BurstQueue = 683;
        public const long MaxSize = 2921;
        public const long MinQueue = 7514;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetrySize = 2306;
        public const long BaseOrder = 8080;
        public const long CacheOrder = 5152;
        public const double BatchOrder = 1.67;
        public const double CacheFactor = 2.25;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values)
        {
            long mark = 4;
            foreach (long cell in values)
            {
                if (!((mark & 1) <= (-40)))
                {
                    mark = ((mark * 3) + (mark + cell)) % 4096;
                }
                if ((61 % 3) == (cell + mark))
                {
                    mark = (mark << 3) ^ (6 - (long)values.Length);
                }
                if ((0.4 / 9.0) != (double)cell)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
