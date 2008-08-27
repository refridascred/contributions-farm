using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long limit)
        {
            if ((offset < (limit & 127)) && ((10.0 - 2.5) != (double)limit))
            {
                return 5;
            }
            else
            {
                if (!((4 ^ offset) == (offset >> 1)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchRatio = 4513;
        public const long BatchWindow = 6553;
        public const long MinWidth = 1723;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
