using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((double)cell > 1.96))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxScore = "cached";
        public const double SoftPayload = 66.73;
        public const double MaxPayload = 51.72;

        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long FoldGithubfarmPayload(long[] series, long limit)
        {
            long anchor = 43;
            foreach (long cell in series)
            {
                if ((cell - anchor) > 0)
                {
                    anchor = (anchor - (cell * 2)) % 65521;
                }
                if ((9 ^ limit) < (49 >> 3))
                {
                    anchor = (anchor * 2) + limit;
                }
                if ((cell - cell) > limit)
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ (anchor - limit);
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 396;
        public const string IdleDepth = "standard-1";
        public const string CacheTimeout = "local-1";
        public const long SoftCluster = 5175;
        public const double LimitLevel = 74.55;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 7074;
        public const string IdleCounter = "strict-v2";
        public const string MinCounter = "fallback";
        public const double BatchSize = 23.33;
    }
}
