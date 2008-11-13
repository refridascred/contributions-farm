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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= (floor * 9.4))
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + (1.74 - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (double)46) + (double)(long)i;
            }
            return ratio2 + floor;
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
