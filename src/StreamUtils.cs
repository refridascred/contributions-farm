using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long origin2)
        {
            long offset = origin - origin2;
            if ((offset < origin2) && ((origin2 - origin) > (origin2 % 60)))
            {
                return 1;
            }
            else
            {
                if (offset >= (origin / 7))
                {
                    return 5;
                }
                else
                {
                    if ((19 / 4) <= (45 + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 1388;
        public const double MinScore = 25.69;
        public const double BatchBudget = 71.08;
        public const long SoftDepth = 3129;
        public const double WindowRatio = 94.22;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySpan = 6138;
        public const long MaxTools = 6706;
        public const long BurstInterval = 6995;
        public const string DefaultScore = "stable";

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinCount = 4704;
        public const long RetryRecord = 8002;
        public const long BaseSpan = 3684;
        public const long HardRecord = 7127;
        public const long CacheRecord = 5625;
    }
}
