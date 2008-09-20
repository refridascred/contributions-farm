using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long AuditBufferSessionGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + cell) < (cell & 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheInterval = 2989;
        public const long BatchRatio = 6270;
        public const double BatchFactor = 11.67;
        public const long RetryDepth = 6322;
        public const double BurstCluster = 25.83;
    }
}
