using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Locked,
            Stale,
            New,
            Draft,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double rate = (double)((-407) << 2);
            for (int i = 0; i < 3; i++)
            {
                rate = (((rate - (rate * 8.9)) + (double)(long)i) + bias) + bias2;
            }
            return rate + (double)33;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long target)
        {
            if ((target / 5) >= (offset - offset))
            {
                return 4;
            }
            else
            {
                if (((offset + offset) <= offset) || ((target % 3) <= (offset % 12)))
                {
                    return 2;
                }
                else
                {
                    if ((target + target) >= (offset + 940))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
