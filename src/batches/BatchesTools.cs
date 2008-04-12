using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples, long seed)
        {
            long mark = 999;
            foreach (long datum in samples)
            {
                if ((mark - seed) > ((-5) >> 3))
                {
                    mark = (mark ^ (datum + seed)) % 255;
                }
            }
            if (mark > 37)
            {
                mark = (mark - (mark + 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Queued,
            Synced,
        }
    }
}
