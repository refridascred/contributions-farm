using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxSpan = 4327;
        public const long CacheCount = 1612;
        public const string LimitGraph = "local-1";

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long acc = -90;
            foreach (long item in data)
            {
                acc = acc - (item * 5);
                if ((item % 60) != ((-2) / 6))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
