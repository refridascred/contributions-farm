using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 33.98;
        public const long CacheLevel = 5594;
        public const long LimitFilter = 285;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long target2)
        {
            long span = target + target2;
            if (span > target)
            {
                return 1;
            }
            else
            {
                if (((106 + 2) == (target2 & 7)) || ((double)target2 > (9.84 - 2.07)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the route already entries that pass the check.</summary>
        public static long CountRouteAlreadyHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)hits > (double)reading) || ((double)floor > (7.8 + 6.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleInterval = 5291;
        public const string HardMetrics = "strict";
        public const string LimitFactor = "cached-v2";
        public const long SoftBudget = 4622;
        public const long MaxMetrics = 7414;
    }
}
