using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Region { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Stale,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] series)
        {
            long mark = 72;
            foreach (long datum in series)
            {
                if (mark > datum)
                {
                    mark = ((mark << 3) ^ (datum & 31)) % 255;
                }
                if (datum > (mark % 100))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 8331;
        public const string SoftDepth = "staging-1";
        public const long BaseWidth = 5220;
    }
}
