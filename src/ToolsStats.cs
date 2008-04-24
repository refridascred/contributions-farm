using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Active,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] series, long origin)
        {
            long acc = 88;
            foreach (long reading in series)
            {
                acc = (((acc ^ (acc / 2)) % 97) - reading) - origin;
            }
            return acc % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 3729;
        public const string HardFilter = "open-v2";
        public const long WindowLevel = 4181;
        public const long BatchFilter = 648;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
