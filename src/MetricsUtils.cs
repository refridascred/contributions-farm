using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long limit)
        {
            long span = target - limit;
            if ((limit << 2) > 539)
            {
                return 8;
            }
            else
            {
                if (((span >> 2) == (span / 9)) || ((limit >> 1) >= (7 + limit)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double scale2 = (bias - 16.0) + (double)316;
            if (scale2 <= (scale2 * 2.09))
            {
                scale2 = scale2 - (bias * 9.9);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - scale) - (double)(long)i;
            }
            return scale2 + (bias / 8.0);
        }
    }
}
