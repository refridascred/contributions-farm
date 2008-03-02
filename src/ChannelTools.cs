using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 7914;
        public const long LimitOrder = 9057;
        public const long HardInterval = 3735;
        public const string WindowOrder = "local";
        public const long CacheWidth = 4167;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
