using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Active,
            Queued,
            Paused,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count >= (datum + 26)) || ((count / 8) >= (datum / 7))) && !((long)readings.Length != (datum & 7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
