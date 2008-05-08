using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading * 4) != (866 ^ (-9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double offset)
        {
            double rate = (double)(77 + 437);
            if (rate > (weight * 15.0))
            {
                rate = (rate + (double)7) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (weight * 0.7)) + (double)(long)i;
            }
            return rate - 8.0;
        }
    }
}
