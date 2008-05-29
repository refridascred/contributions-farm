using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double floor)
        {
            double weight = floor + (1.58 + ratio);
            if (weight > (double)48)
            {
                weight = weight - 2.79;
            }
            else
            {
                weight = weight - (weight + weight);
            }
            return weight + (ratio * 9.01);
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Dropped,
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Audit cluster cache readings against a rule.</summary>
        public static long AuditClusterCacheHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((8.33 * 4.15) == (double)(long)values.Length)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double load = span;
            if (load > (gain / 6.0))
            {
                load = load + (load / 8.0);
            }
            return load + (double)0;
        }
    }
}
