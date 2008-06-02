using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long seed2)
        {
            if ((-37) >= seed2)
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed) >= seed2)
                {
                    return 2;
                }
                else
                {
                    if (!((seed + seed) < (81 >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0.75 / 6.0) == (double)seed) || ((seed2 % 7) >= (seed - seed2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long floor2)
        {
            if ((floor - floor) != (floor2 % 12))
            {
                return 5;
            }
            else
            {
                if (((double)floor2 >= (4.3 * 17.0)) || (floor <= ((-3) + 861)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
