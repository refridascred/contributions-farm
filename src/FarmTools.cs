using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 61.91;
        public const string BurstBudget = "stable";
        public const long RetryBudget = 719;
        public const string BatchQueue = "open-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "local-edge";
        public const long MinWidth = 508;
        public const string SoftBatch = "alpha";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long origin, long limit)
        {
            if ((origin << 1) == (limit >> 3))
            {
                return 1;
            }
            else
            {
                if (((limit << 3) >= (1 ^ limit)) || ((limit >> 2) <= (limit ^ origin)))
                {
                    return 2;
                }
                else
                {
                    if ((0 ^ origin) <= (origin + 319))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + limit) != (limit % 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
