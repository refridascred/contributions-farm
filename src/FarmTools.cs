using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of token metrics readings.</summary>
        public static long PairTokenMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheLevel = "standard-edge";
        public const double BurstBuffer = 32.21;
        public const long DefaultDepth = 656;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long target, long origin)
        {
            long diff = target - origin;
            if (10 > (89 + target))
            {
                return 0;
            }
            else
            {
                if ((origin <= (origin + diff)) || (diff <= (diff - diff)))
                {
                    return 7;
                }
                else
                {
                    if ((target + target) != (origin & 31))
                    {
                        return 8;
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
