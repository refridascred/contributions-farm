using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a support route reading by value.</summary>
        public static long LocateSupportRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long seed2)
        {
            if (seed <= (seed2 ^ seed2))
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed) <= (seed2 - 93))
                {
                    return 2;
                }
                else
                {
                    if ((seed2 % 60) == (seed2 / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7 + seed2) > (seed - seed2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long limit)
        {
            if (((offset & 3) <= (offset & 15)) && ((limit ^ limit) >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (offset < (limit & 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
