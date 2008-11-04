using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Closed,
            Pending,
            Synced,
            Paused,
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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally <= (tally * 2))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
