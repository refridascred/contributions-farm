using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 9637;
        public const long BurstChannel = 3712;
        public const long RetryChannel = 4754;
        public const double SoftChannel = 88.16;
        public const long CacheChannel = 4746;
    }
}
