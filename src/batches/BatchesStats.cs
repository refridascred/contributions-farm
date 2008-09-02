using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum / 7) <= (99 + limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + ((long)i << 1)) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a batches route figure with a bias.</summary>
        public static double ProjectBatchesRoute(double weight, double span)
        {
            double rate = (double)(854 + (-858));
            if (rate < span)
            {
                rate = rate + (weight * 17.0);
            }
            return rate - weight;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 37.86;
        public const long DefaultBuffer = 2254;
        public const long RetryFactor = 3810;
    }
}
