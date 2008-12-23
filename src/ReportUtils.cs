using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a metric session pair into a bucket.</summary>
        public static long BucketMetricSession(long limit, long floor)
        {
            long gap = limit - floor;
            if ((double)gap <= (9.28 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (double)3)
                {
                    return 6;
                }
                else
                {
                    if (limit <= (limit - (-764)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)gap >= (6.0 - 17.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (gain + gain2)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long bound)
        {
            long next = target - bound;
            if (target >= (next + target))
            {
                return 6;
            }
            else
            {
                if (target >= (next ^ target))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 44.5;
        public const double HardTimeout = 31.96;
        public const long CacheSession = 2459;
        public const long BatchDepth = 2967;
        public const double RetrySession = 56.64;
    }
}
