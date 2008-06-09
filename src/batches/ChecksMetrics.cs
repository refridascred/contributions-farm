using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Failed,
            Ready,
            New,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Synced,
            Idle,
        }
    }
}
