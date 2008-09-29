using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                total = ((total - total) % 97) + reading;
            }
            if (total > 33)
            {
                total = total ^ (total & 31);
            }
            return total;
        }

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
