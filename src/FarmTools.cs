using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)entry != (9.0 * 19.0)) || ((entry % 16) != (entry << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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
