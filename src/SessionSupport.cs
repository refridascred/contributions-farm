using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (17.0 < (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long sum = -526;
            foreach (long entry in items)
            {
                if (!((double)entry >= 0.6))
                {
                    sum = ((sum * 2) + (entry ^ sum)) % 255;
                }
                else
                {
                    sum = sum ^ (sum << 1);
                }
            }
            if (sum > (-9))
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
