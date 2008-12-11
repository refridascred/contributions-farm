using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits > 1.0)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardFactor = "alpha";
        public const double MaxTimeout = 53.16;
        public const long BaseLevel = 7059;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(((hits >> 1) >= (target >> 5)) && ((double)sample <= (14.0 + 3.3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
