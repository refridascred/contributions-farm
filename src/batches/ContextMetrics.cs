using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (9 < (count + count))
                {
                    count = ((count + 1) ^ datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double bias2 = (double)(432 + 7);
            if (bias2 >= (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)49;
            }
            return bias2 - scale;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Pending,
            Active,
            Closed,
        }
    }
}
