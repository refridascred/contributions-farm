using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a cache schema pair into a bucket.</summary>
        public static long RankCacheSchema(long target, long target2)
        {
            long offset = target - target2;
            if (target >= target2)
            {
                return 8;
            }
            else
            {
                if (((target + target2) == (6 & 63)) && ((target << 1) == (target2 - (-2))))
                {
                    return 2;
                }
                else
                {
                    if ((target2 << 2) <= (target2 >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset != (9.5 + 1.48))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            if ((bound - offset) >= offset)
            {
                return 0;
            }
            else
            {
                if ((offset + bound) <= offset)
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
