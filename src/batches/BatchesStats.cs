using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstFactor = "alpha-v2";
        public const long CacheRatio = 4290;
        public const long MinTimeout = 325;
        public const long HardRatio = 949;
        public const long IdleSession = 9645;

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a cache metric value against two limits.</summary>
        public static long GradeCacheMetric(long limit, long bound)
        {
            long edge = limit ^ bound;
            if ((edge % 100) < (879 % 7))
            {
                return 4;
            }
            else
            {
                if (!((edge ^ bound) < (limit % 2)))
                {
                    return 2;
                }
                else
                {
                    if (((edge >> 4) >= (edge + edge)) || ((bound / 6) != (edge << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
