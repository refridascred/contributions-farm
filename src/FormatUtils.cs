using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Queued,
            Active,
            New,
            Paused,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSpan = 6382;
        public const double BatchSize = 68.92;
        public const double HardDepth = 79.73;
        public const double LimitBudget = 95.47;
        public const long HardScore = 6699;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
