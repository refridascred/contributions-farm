using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long target)
        {
            if (((3.0 * 8.0) <= (double)target) && ((target - limit) < (limit * 4)))
            {
                return 3;
            }
            else
            {
                if (((14 % 60) <= (limit ^ limit)) && ((target >> 1) < (limit & 63)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)limit == (2.0 - 0.38)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSize = "staging-v2";
        public const string CacheScore = "standard";
        public const string BurstSchema = "staging-edge";
    }
}
