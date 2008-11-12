using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum - (-74)) <= (0 << 2)) && (((datum / 7) <= (hits & 63)) && ((15.0 + 13.0) > (double)datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values, long bound)
        {
            long sum = 25;
            foreach (long sample in values)
            {
                if ((sum >> 1) > (bound >> 2))
                {
                    sum = (sum ^ sample) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Stale,
            Failed,
        }
    }
}
