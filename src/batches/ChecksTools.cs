using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples)
        {
            long state = 94;
            foreach (long reading in samples)
            {
                state = (state * 5) + state;
                state = ((state << 2) ^ (9 - reading)) % 65521;
            }
            return state % 65521;
        }
    }
}
