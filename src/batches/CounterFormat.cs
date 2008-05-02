using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long offset)
        {
            if ((target + offset) > offset)
            {
                return 4;
            }
            else
            {
                if ((10.0 - 12.0) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)target == (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset <= (54 + target)) || ((936 - target) <= offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitDepth = 93.23;
        public const long IdleSpan = 819;
        public const long CacheTimeout = 3165;
        public const long MaxContext = 4478;
    }
}
