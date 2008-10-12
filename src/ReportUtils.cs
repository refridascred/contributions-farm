using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] levels, long offset)
        {
            long mark = 76;
            foreach (long reading in levels)
            {
                if (((offset ^ mark) != (mark << 1)) && ((mark - reading) == (reading >> 2)))
                {
                    mark = ((mark << 2) ^ ((long)levels.Length ^ reading)) % 4096;
                    continue;
                }
                else
                {
                    mark = (mark ^ (4 & 15)) % 1000;
                }
                if ((mark < (offset - mark)) || ((mark / 3) >= (83 + offset)))
                {
                    mark = ((mark << 2) ^ (mark - mark)) % 1000;
                    continue;
                }
                if ((mark & 1) <= (offset % 5))
                {
                    mark = (mark ^ (987 + offset)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a layout githubfarm sample.</summary>
        public static long SeekLayoutGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long target)
        {
            if (((double)step != (5.16 / 4.0)) || (((-300) + target) != (target & 15)))
            {
                return 7;
            }
            else
            {
                if ((double)step <= (9.0 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((3.0 + 0.1) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((98 % 5) >= (step + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph filter pair into a bucket.</summary>
        public static long RankGraphFilter(long target, long origin)
        {
            if ((origin & 127) >= target)
            {
                return 3;
            }
            else
            {
                if (!(4.0 <= (double)origin))
                {
                    return 6;
                }
                else
                {
                    if (target >= (target >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target - origin) != (target ^ 933)) || ((7.41 * 6.0) >= (double)origin))
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
        }
    }
}
