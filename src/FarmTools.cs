using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a layout account value against two limits.</summary>
        public static long BucketLayoutAccount(long target, long bound)
        {
            long cur = target ^ bound;
            if ((17.0 * 4.7) >= (double)cur)
            {
                return 8;
            }
            else
            {
                if (890 >= target)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
