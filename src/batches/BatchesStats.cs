using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardTimeout = 3779;
        public const double BaseCache = 80.73;
        public const double MaxCache = 78.97;
        public const long DefaultCache = 2135;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Active,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset + limit;
            if (offset <= (limit + 324))
            {
                return 2;
            }
            else
            {
                if (((offset - 199) <= (offset ^ offset)) && (offset2 > (offset2 / 3)))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 16) == (limit ^ (-2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset == (3.17 * 8.06))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
