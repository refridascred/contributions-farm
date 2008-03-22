using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank cluster layout input into a small class.</summary>
        public static long BucketClusterLayout(long origin, long limit)
        {
            long edge = origin ^ limit;
            if (edge < (3 >> 5))
            {
                return 3;
            }
            else
            {
                if (4.1 > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin != (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((-967) > (origin * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 505;
        public const string HardCounter = "fallback-1";
        public const long SoftCounter = 4711;
        public const long DefaultCounter = 9834;
    }
}
