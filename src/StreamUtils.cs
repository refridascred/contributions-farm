using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseBudget = 7673;
        public const double BurstSize = 13.16;
        public const double DefaultLevel = 63.19;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 19.63;
        public const double BurstBuffer = 1.0;
        public const long SoftSpan = 6960;
        public const long BaseBuffer = 1766;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item - item) <= item)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 6.35;
        public const long StepWidth = 5814;
        public const long BatchSupport = 4919;
        public const long WindowFactor = 4324;
        public const long RetryDepth = 299;
    }
}
