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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ (floor ^ total);
                total = ((total * 5) + (total + total)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepSize = 8951;
        public const string SoftLayout = "primary-edge";
        public const double BaseSpan = 7.68;
        public const long IdleTimeout = 3774;
    }
}
