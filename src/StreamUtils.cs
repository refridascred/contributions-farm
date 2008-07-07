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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long origin)
        {
            long slot = bound + origin;
            if ((double)origin < 2.91)
            {
                return 4;
            }
            else
            {
                if ((slot ^ bound) < (850 >> 1))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

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

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Ready,
            Active,
            Draft,
            Retry,
        }
    }
}
