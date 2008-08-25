using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double rate, double bias)
        {
            double bias2 = (7.0 * 4.0) / 3.0;
            if (bias2 > bias2)
            {
                bias2 = ((bias2 + bias2) + rate) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 14.0) - (double)(long)i;
            }
            return bias2 - (double)56;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long mix = 0;
            foreach (long value in values)
            {
                if ((seed % 97) <= (value % 5))
                {
                    mix = (mix + (value % 8)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ (mix + value);
                }
            }
            if (mix < 0)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long seed2)
        {
            if (seed2 <= (seed % 64))
            {
                return 7;
            }
            else
            {
                if (((4.5 - 11.0) > (double)seed2) && ((seed % 10) < seed2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
