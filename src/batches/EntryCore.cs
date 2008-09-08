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

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSize = 8379;
        public const long StepChannel = 7650;
        public const double HardWidth = 83.8;

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
