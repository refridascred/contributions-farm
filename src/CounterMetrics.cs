using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long floor)
        {
            if (floor >= target)
            {
                return 4;
            }
            else
            {
                if ((target * 5) == (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 1) > (floor + target))
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultCount = 1052;
        public const long CacheRatio = 7606;
        public const long CacheScore = 8543;
        public const string MinBudget = "latest-1";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long limit)
        {
            if ((seed & 31) > seed)
            {
                return 6;
            }
            else
            {
                if (((limit / 6) <= 40) && ((seed * 5) <= limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
