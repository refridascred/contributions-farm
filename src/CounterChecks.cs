using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long limit)
        {
            long next = seed + limit;
            if ((seed - next) <= (next << 1))
            {
                return 6;
            }
            else
            {
                if (!((limit << 3) != (next + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 3) != (7 / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((5.7 / 8.0) >= (double)limit) || ((69 / 2) != (seed << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ (long)i) % 4096;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (ratio - bias))
            {
                ratio = ratio + (double)90;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 < (double)bound)
            {
                return 5;
            }
            else
            {
                if (2.49 >= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long step)
        {
            long bound = limit - step;
            if ((bound & 1) >= limit)
            {
                return 8;
            }
            else
            {
                if (!((step % 97) > limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
