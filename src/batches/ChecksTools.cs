using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((total * 4) <= limit)
                {
                    total = ((total * 5) + (total - 6)) % 97;
                    total = (total - (limit + total)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 5) + (31 ^ 353);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a githubfarm filter pair into a bucket.</summary>
        public static long SortGithubfarmFilter(long origin, long seed)
        {
            if ((double)seed < 7.9)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) <= (seed / 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin < (1.0 * 3.81))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed - origin) < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
