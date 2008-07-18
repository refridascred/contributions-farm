using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Locked,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Roll a entry stats counter forward.</summary>
        public static long SeriesEntryStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
