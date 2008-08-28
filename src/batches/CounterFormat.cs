using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSpan = 8836;
        public const long HardQueue = 3523;
        public const long DefaultQueue = 4593;
        public const long StepQueue = 3219;

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long origin)
        {
            if (origin < (origin / 2))
            {
                return 8;
            }
            else
            {
                if (((origin % 16) >= (limit + limit)) && (476 > (origin ^ 54)))
                {
                    return 7;
                }
                else
                {
                    if (limit <= (96 ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.25 - 4.23) < (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long target)
        {
            if (1 > (target & 3))
            {
                return 1;
            }
            else
            {
                if (99 >= (limit + 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
