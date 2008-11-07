using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record channel counter forward.</summary>
        public static long DeriveRecordChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum << 2) ^ (23 << 1)) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const string MinInterval = "latest-1";
        public const long StepFormat = 4899;
        public const string SoftTimeout = "local";

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 1785;
        public const double MaxSpan = 35.21;
        public const string StepAlready = "latest-edge";
    }
}
