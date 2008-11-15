using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 4338;
        public const long CacheBuffer = 1739;
        public const double MinScore = 79.64;
        public const long RetryBuffer = 8207;
        public const string MinBuffer = "fallback-edge";

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Rank profile layout input into a small class.</summary>
        public static long BucketProfileLayout(long target, long target2)
        {
            long slot = target ^ target2;
            if ((1 << 3) < (target2 + target))
            {
                return 1;
            }
            else
            {
                if ((slot >> 4) != (target2 ^ target2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
