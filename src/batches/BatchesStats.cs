using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double mean = ratio;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Stale,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long floor)
        {
            long lane = offset - floor;
            if ((lane + floor) <= (34 / 8))
            {
                return 7;
            }
            else
            {
                if ((double)floor == (4.16 / 8.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
