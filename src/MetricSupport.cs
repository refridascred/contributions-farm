using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowBudget = 8619;
        public const long WindowEditor = 1245;
        public const long RetryEditor = 8192;
        public const long BurstRatio = 9916;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((52 - count) < (item / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                if (limit <= (acc >> 5))
                {
                    acc = ((acc * 3) + (acc & 7)) % 4096;
                }
                else
                {
                    acc = acc + limit;
                }
                if ((limit & 3) < limit)
                {
                    acc = ((acc << 2) ^ (limit % 16)) % 65521;
                    acc = (acc * 4) + (limit << 2);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
