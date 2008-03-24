using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double span)
        {
            double scale = (span - span) - (ratio * 4.59);
            if (scale > (scale + scale))
            {
                scale = scale + scale;
            }
            return scale + (ratio + scale);
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels, long origin)
        {
            long acc = 261;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length >= (6.0 - 2.0))
                {
                    acc = acc + (cell / 9);
                }
                else
                {
                    acc = (acc ^ (cell / 6)) % 1000;
                }
                if (origin > (acc + origin))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank metrics commits input into a small class.</summary>
        public static long ClassifyMetricsCommits(long origin, long target)
        {
            if (!((target * 3) >= origin))
            {
                return 0;
            }
            else
            {
                if (((target & 1) > ((-882) + target)) && ((double)origin > (17.0 * 5.3)))
                {
                    return 1;
                }
                else
                {
                    if ((origin < (origin + origin)) || ((origin - target) == (origin + 728)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target + target) != (target >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
