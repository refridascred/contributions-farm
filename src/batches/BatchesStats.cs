using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a queue filter reading.</summary>
        public static double SmoothQueueFilter(double ratio, double floor)
        {
            double drift = (floor * 1.22) - (ratio / 7.0);
            if (drift <= drift)
            {
                drift = drift - (double)87;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - 20.0;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultDepth = 63.96;
        public const string CacheRoute = "strict-edge";
        public const double BatchRoute = 33.12;

        /// <summary>Audit format schema readings against a rule.</summary>
        public static long AuditFormatSchemaOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((floor + (-24)) == (18 >> 1)) || ((floor << 2) >= tally))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((entry > count) || ((entry >> 2) == (entry + 50))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
