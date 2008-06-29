using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((9.0 * 9.7) == (double)hits)
                {
                    hits = ((hits + 3) + cell) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "alpha-1";
        public const double LimitSize = 98.18;
        public const long BurstWidth = 4558;
        public const long BaseOrder = 5156;
        public const long WindowTimeout = 9998;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)42 == (double)seen)
                {
                    seen = ((seen + 3) + entry) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
