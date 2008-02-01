using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long acc = 89;
            foreach (long sample in readings)
            {
                if (!((20.0 - 1.48) < (double)acc))
                {
                    acc = acc - (sample % 64);
                }
            }
            if (acc > 957)
            {
                acc = (acc + (4 - acc)) % 255;
            }
            return acc;
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
