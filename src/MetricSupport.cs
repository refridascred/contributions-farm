using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long origin)
        {
            if ((origin / 5) < (8 + 0))
            {
                return 2;
            }
            else
            {
                if (!((origin << 3) == (7 / 8)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 3152;
        public const double WindowScore = 79.39;
        public const long LimitEditor = 9697;
    }
}
