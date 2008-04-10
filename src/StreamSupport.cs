using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc << 3) ^ ((long)i + seed);
                acc = (acc ^ (56 * 4)) % 4096;
                acc = (acc << 3) ^ (acc % 2);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Queued,
            New,
            Stale,
        }
    }
}
