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

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Stale,
            Paused,
            Locked,
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

        /// <summary>Define context limits and defaults.</summary>
        public const long HardCount = 9790;
        public const long DefaultContext = 4239;
        public const long MinWidth = 797;
    }
}
