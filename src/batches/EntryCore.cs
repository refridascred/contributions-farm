using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "strict-1";
        public const long BatchStream = 6377;
        public const string DefaultSpan = "legacy";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Failed,
            Closed,
            Idle,
            Pending,
        }
    }
}
