using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a farm route reading by value.</summary>
        public static long SeekFarmRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long bound)
        {
            if (((bound / 4) != (limit + bound)) && ((limit + 58) >= bound))
            {
                return 0;
            }
            else
            {
                if ((bound ^ limit) < bound)
                {
                    return 3;
                }
                else
                {
                    if (!((bound + bound) >= limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound % 16) > bound) || (((-406) & 63) <= (bound + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
