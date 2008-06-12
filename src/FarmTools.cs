using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool VerifyTokenCacheRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            if (seed <= (bound + bound))
            {
                return 7;
            }
            else
            {
                if (((2.4 + 3.43) < (double)bound) && ((double)bound < (double)6))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) == (seed ^ bound)) && (bound >= (bound << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((2 >> 3) != (hits ^ 0)) && !(hits > (hits - sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
