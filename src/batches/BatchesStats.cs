using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long target)
        {
            if (target >= (66 + limit))
            {
                return 4;
            }
            else
            {
                if ((limit ^ limit) != (15 * 2))
                {
                    return 1;
                }
                else
                {
                    if (target <= (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 5) == (target << 3))
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

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long bound, long seed)
        {
            if ((seed - seed) <= (seed << 1))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) >= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound + seed) < (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed & 7) <= (seed + 6)) || ((double)seed != (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (5 > (matches ^ 64))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
