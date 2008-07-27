using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }
    }
}
