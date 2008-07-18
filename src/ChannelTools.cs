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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry / 8) < hits) || (entry > (floor & 15)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
