using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values, long origin)
        {
            long total = 2;
            foreach (long cell in values)
            {
                if ((total & 15) < (origin + origin))
                {
                    total = (total - (total + origin)) % 4096;
                }
                else
                {
                    total = total - (cell & 127);
                }
            }
            if (total < (-78))
            {
                total = total + (27 * 3);
            }
            return total % 65521;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] readings, long limit)
        {
            long state = 306;
            foreach (long value in readings)
            {
                state = ((state ^ (long)readings.Length) + value) + limit;
            }
            return state;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long target, long origin)
        {
            if (((2.0 * 13.0) != (double)target) && (3.39 < (double)origin))
            {
                return 2;
            }
            else
            {
                if ((target < (target + 92)) && ((double)target < 5.78))
                {
                    return 6;
                }
                else
                {
                    if (target <= 14)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.0 / 8.0) != (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
