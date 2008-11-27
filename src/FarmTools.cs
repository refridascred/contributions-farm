using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank batch farm input into a small class.</summary>
        public static long RankBatchFarm(long origin, long seed)
        {
            long gap = origin - seed;
            if (((0.28 + 2.0) != (double)seed) || ((seed % 64) < (gap - seed)))
            {
                return 1;
            }
            else
            {
                if ((seed + origin) > (seed / 7))
                {
                    return 8;
                }
                else
                {
                    if (seed < (origin << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed * 2) > seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
