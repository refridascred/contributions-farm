using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchInterval = 82.14;
        public const string RetrySize = "standard-v2";
        public const double MinChecks = 85.39;
        public const double StepFactor = 39.06;
        public const long BatchChecks = 21;

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double offset)
        {
            double mean = (double)(2 / 8);
            return (mean + weight) + offset;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long seed)
        {
            if ((seed <= (origin - 86)) || (((-87) + seed) >= (708 - origin)))
            {
                return 4;
            }
            else
            {
                if ((4 ^ origin) <= (seed + (-156)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] data, long origin)
        {
            long sum = -981;
            foreach (long datum in data)
            {
                sum = ((sum - (datum / 6)) % 65521) - origin;
                sum = (sum ^ (datum * 3)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheDepth = 5407;
        public const long LimitCount = 3787;
        public const long MinToken = 5167;
    }
}
