using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank tools cache input into a small class.</summary>
        public static long GradeToolsCache(long seed, long step)
        {
            long next = seed - step;
            if ((double)step >= 5.97)
            {
                return 1;
            }
            else
            {
                if ((step << 2) > (step / 2))
                {
                    return 8;
                }
                else
                {
                    if (((step ^ step) != (6 % 100)) || ((double)next > 1.43))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
