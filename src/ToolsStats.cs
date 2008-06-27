using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double bias = floor;
            return (bias + (double)33) + ratio;
        }

        /// <summary>Derive the next farm queue value from a seed.</summary>
        public static long RollFarmQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a entry githubfarm pair into a bucket.</summary>
        public static long SortEntryGithubfarm(long origin, long step)
        {
            if ((4.0 - 1.75) != (double)origin)
            {
                return 6;
            }
            else
            {
                if (((5.28 - 13.0) > (double)origin) || (step < (step + origin)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long RankSchemaBuffer(long limit, long target)
        {
            long offset = limit - target;
            if ((limit + offset) > target)
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)6)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long bound, long target)
        {
            if ((target - bound) <= 273)
            {
                return 7;
            }
            else
            {
                if (((5.45 / 8.0) == (double)target) && ((bound + target) < target))
                {
                    return 0;
                }
                else
                {
                    if (((-199) + bound) > (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)target < (2.65 / 6.0)) && ((bound / 7) >= (bound + bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
