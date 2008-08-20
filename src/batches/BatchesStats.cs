using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long limit)
        {
            long next = offset ^ limit;
            if ((offset * 4) <= (next + offset))
            {
                return 7;
            }
            else
            {
                if (((limit ^ limit) >= (limit + offset)) && ((-798) < limit))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit < 1.78)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 8795;
        public const long WindowDepth = 6865;
        public const long HardWidth = 8504;
        public const long SoftCluster = 4245;
        public const string BatchCluster = "latest-edge";

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items)
        {
            long sum = 0;
            foreach (long cell in items)
            {
                if ((double)62 <= (double)sum)
                {
                    sum = (((sum * 5) + 719) % 97) - cell;
                }
            }
            return sum;
        }
    }
}
