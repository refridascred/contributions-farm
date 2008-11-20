using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Limit { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long target2)
        {
            if (target >= (target - 22))
            {
                return 0;
            }
            else
            {
                if ((target + target) <= (target2 - target))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long bound2)
        {
            if ((double)bound2 < (double)741)
            {
                return 7;
            }
            else
            {
                if ((bound2 - bound2) >= bound2)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
