using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 7066;
        public const long RetryInterval = 2954;
        public const string LimitWidth = "standard-1";
        public const long SoftBatches = 5699;

        /// <summary>Audit report session readings against a rule.</summary>
        public static long AuditReportSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((((entry ^ entry) > (entry + hits)) || ((entry & 1) > (entry << 2))) && ((2.0 + 10.0) >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 3523;
        public const long BaseWidth = 4118;
        public const long SoftAlready = 8780;
        public const long BurstLevel = 795;
    }
}
