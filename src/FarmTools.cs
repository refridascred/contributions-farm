using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "primary-1";
        public const long MinCount = 7526;
        public const string MinDepth = "standard-v2";

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long seed, long limit)
        {
            long offset = seed - limit;
            if ((limit - offset) < (limit & 255))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) > ((-4) / 9))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
