using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batch payload value.</summary>
        public static double ProjectBatchPayload(double weight, double offset)
        {
            double drift = offset - (weight / 6.0);
            if (drift > (double)2)
            {
                drift = drift - (double)3;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (weight / 2.0);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits < 470)
                {
                    hits = ((hits + 3) ^ datum) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Active,
            Retry,
            Dropped,
            Stale,
        }
    }
}
