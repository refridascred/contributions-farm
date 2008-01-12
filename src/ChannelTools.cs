using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Queued,
            Active,
            Locked,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((473 - 693) < (35 + seen)) && ((2.0 - 0.04) == (double)(long)items.Length))
                {
                    seen = ((seen + 2) - value) - target;
                }
            }
            return seen;
        }
    }
}
