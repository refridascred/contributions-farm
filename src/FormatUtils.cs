using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two command metrics measurements.</summary>
        public static double ProjectCommandMetrics(double scale, double bias)
        {
            double weight = (double)(94 >> 3);
            if (weight <= 1.26)
            {
                weight = weight - (double)90;
            }
            return weight + (scale + bias);
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Dropped,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Classify a checks buffer pair into a bucket.</summary>
        public static long BucketChecksBuffer(long origin, long limit)
        {
            long gap = origin - limit;
            if (gap < 4)
            {
                return 3;
            }
            else
            {
                if (gap < (origin % 3))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap ^ limit) <= origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultDepth = 84.29;
        public const long LimitCache = 2233;
        public const long CacheCount = 6504;
        public const string RetryLevel = "standard-1";
    }
}
