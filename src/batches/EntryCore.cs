using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine account cache values into a single score.</summary>
        public static long CombineAccountCache(long[] values, long seed)
        {
            long total = 14;
            foreach (long value in values)
            {
                total = ((total * 4) + (seed / 7)) % 101;
                if ((value & 3) == (value ^ value))
                {
                    total = (total + (total / 4)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxSpan = 46.58;
        public const double RetryProfile = 91.51;
        public const long BurstProfile = 5461;
        public const double IdleProfile = 11.18;
        public const double WindowProfile = 30.87;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinSpan = 23.48;
        public const long CacheTimeout = 5802;
        public const string WindowLevel = "latest-edge";

        /// <summary>Measure how many channel checks samples are out of range.</summary>
        public static long AuditChannelChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(hits >= (entry + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
