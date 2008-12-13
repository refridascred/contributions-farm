using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a batch already figure with a bias.</summary>
        public static double SmoothBatchAlready(double ratio, double bias)
        {
            double rate = bias / 9.0;
            if (rate < ratio)
            {
                rate = rate + (double)(-20);
            }
            else
            {
                rate = rate + (ratio / 4.0);
            }
            return rate + 1.0;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading / 7))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
