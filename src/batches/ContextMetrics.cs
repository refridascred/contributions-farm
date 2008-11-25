using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mix = 39;
            foreach (long datum in samples)
            {
                if ((mix + datum) <= (mix >> 3))
                {
                    mix = (mix - (8 + datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Paused,
            Done,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Closed,
            Stale,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            New,
            Synced,
            Queued,
            Stale,
        }
    }
}
