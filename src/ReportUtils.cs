using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long floor)
        {
            if ((floor - floor) >= (35 % 24))
            {
                return 6;
            }
            else
            {
                if ((floor + bound) > 95)
                {
                    return 1;
                }
                else
                {
                    if (((double)bound > (8.1 * 9.3)) || ((10.0 + 4.5) <= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (5.59 > (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long offset)
        {
            if ((1 ^ bound) == (bound ^ offset))
            {
                return 7;
            }
            else
            {
                if ((bound * 3) <= (offset % 60))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 63) != (0 << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset >> 1) != (offset & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a cache account pair into a bucket.</summary>
        public static long GradeCacheAccount(long origin, long limit)
        {
            if ((limit / 4) < (8 << 2))
            {
                return 6;
            }
            else
            {
                if (limit < 0)
                {
                    return 4;
                }
                else
                {
                    if (!((double)917 == (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long limit)
        {
            if ((limit + offset) <= (6 >> 5))
            {
                return 4;
            }
            else
            {
                if ((limit * 3) < (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (((offset >> 5) <= (404 + limit)) || ((limit / 8) < 93))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit & 63) < 79)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
