using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

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
