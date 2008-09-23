using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long seed)
        {
            if ((98 - seed) == (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((bound + seed) < (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < 5.3)
                    {
                        return 6;
                    }
                    else
                    {
                        if (921 < bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a record session value against two limits.</summary>
        public static long RankRecordSession(long floor, long target)
        {
            long bound = floor + target;
            if ((target << 1) >= bound)
            {
                return 3;
            }
            else
            {
                if ((double)bound == (8.0 * 6.0))
                {
                    return 2;
                }
                else
                {
                    if (9 > (floor + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound >> 5) >= (target - (-44)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long seed)
        {
            long gap = limit ^ seed;
            if ((limit + gap) <= limit)
            {
                return 5;
            }
            else
            {
                if ((gap ^ seed) != (231 / 2))
                {
                    return 2;
                }
                else
                {
                    if ((566 + gap) != (37 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < (seed + 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
