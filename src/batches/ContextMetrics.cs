using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Retry,
            Queued,
            Pending,
            Idle,
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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double scale, double floor)
        {
            double rate = scale;
            if (rate < 17.0)
            {
                rate = rate + (double)28;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)0) + (double)(long)i;
            }
            return rate - (floor / 9.0);
        }
    }
}
