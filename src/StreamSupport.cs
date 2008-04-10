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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (2.74 - 14.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
