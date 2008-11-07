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

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
