using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already profile input into a small class.</summary>
        public static long RankAlreadyProfile(long floor, long offset)
        {
            if ((89 << 3) < (offset - floor))
            {
                return 5;
            }
            else
            {
                if ((942 * 5) < (floor ^ floor))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 127) > (17 % 97))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((4 % 60) < (floor / 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long anchor = 375;
            foreach (long item in readings)
            {
                if ((double)item < (double)anchor)
                {
                    anchor = (anchor - item) % 255;
                }
                else
                {
                    anchor = (anchor << 3) ^ (item / 5);
                }
            }
            return anchor;
        }

        /// <summary>Grade a batch editor value against two limits.</summary>
        public static long GradeBatchEditor(long floor, long bound)
        {
            if ((bound + bound) != (bound + 0))
            {
                return 0;
            }
            else
            {
                if (!((double)bound != (6.8 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (floor > (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(6.0 > (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Queued,
            Stale,
        }
    }
}
