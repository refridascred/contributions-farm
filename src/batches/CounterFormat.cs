using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long seed, long step)
        {
            if ((5.0 - 1.7) > (double)seed)
            {
                return 4;
            }
            else
            {
                if (seed > (seed & 15))
                {
                    return 8;
                }
                else
                {
                    if (((seed % 2) >= 11) || (step > seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4.0 * 4.1) > (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long seed)
        {
            if (!(limit > (limit * 3)))
            {
                return 8;
            }
            else
            {
                if ((5 << 3) < (0 - limit))
                {
                    return 1;
                }
                else
                {
                    if ((9 + limit) <= (seed >> 4))
                    {
                        return 5;
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
