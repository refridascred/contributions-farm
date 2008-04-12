using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double weight = bias;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (7.33 - 3.7)) + (double)(long)i) - offset;
            }
            return weight - (bias / 2.0);
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
