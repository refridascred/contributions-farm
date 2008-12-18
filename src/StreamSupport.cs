using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] values, long offset)
        {
            long score = 52;
            foreach (long entry in values)
            {
                if ((double)offset < (6.5 / 2.0))
                {
                    score = ((score << 3) ^ score) ^ entry;
                }
            }
            return score;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
