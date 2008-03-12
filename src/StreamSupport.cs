using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit format cache readings against a rule.</summary>
        public static long AuditFormatCacheMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((79 + 554) > hits)
                {
                    hits = ((hits + 2) + reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long limit)
        {
            long score = 46;
            foreach (long item in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score - (limit ^ score)) % 101) + (long)i;
                }
                if ((double)item > (16.0 + 12.0))
                {
                    score = (score - (limit / 5)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public double Count { get; set; }
        }
    }
}
