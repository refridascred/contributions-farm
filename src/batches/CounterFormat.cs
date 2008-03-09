using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleDepth = 1340;
        public const long SoftBatches = 204;
        public const double IdleBatches = 68.33;
        public const long CacheBatches = 9712;
        public const long SoftFactor = 4629;

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long limit)
        {
            long edge = origin + limit;
            if (edge <= (origin * 2))
            {
                return 0;
            }
            else
            {
                if ((origin & 255) > limit)
                {
                    return 7;
                }
                else
                {
                    if ((2 % 3) != (edge - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
