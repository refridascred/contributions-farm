using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long offset)
        {
            if ((double)offset <= (6.7 / 9.0))
            {
                return 5;
            }
            else
            {
                if (!((offset >> 3) > floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long limit)
        {
            if ((double)limit < (1.9 + 8.9))
            {
                return 5;
            }
            else
            {
                if (!((limit + (-66)) >= (step ^ limit)))
                {
                    return 0;
                }
                else
                {
                    if ((12.0 / 4.0) >= (double)step)
                    {
                        return 2;
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
