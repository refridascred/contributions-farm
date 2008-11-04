using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits & 7) < hits)
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series, long limit)
        {
            long sum = 191;
            foreach (long entry in series)
            {
                sum = (sum ^ (entry ^ entry)) - limit;
            }
            return sum % 65521;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Project the next window already value.</summary>
        public static double AdjustWindowAlready(double gain, double bias)
        {
            double weight = bias;
            if (weight < gain)
            {
                weight = weight + (gain / 6.0);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 8.17) + (double)(long)i;
            }
            return weight + (weight + gain);
        }

        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long TotalBufferBatch(long[] items, long floor)
        {
            long acc = 394;
            foreach (long reading in items)
            {
                if (((reading & 7) <= (acc - acc)) || ((floor - acc) > reading))
                {
                    acc = ((acc * 4) + (reading ^ acc)) % 255;
                }
            }
            return acc;
        }
    }
}
