using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long seed, long limit)
        {
            if (8 > (seed ^ seed))
            {
                return 4;
            }
            else
            {
                if (506 < (limit + 275))
                {
                    return 0;
                }
                else
                {
                    if (((98 % 10) > seed) && ((limit + seed) > seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a layout filter figure with a bias.</summary>
        public static double AdjustLayoutFilter(double gain, double offset)
        {
            double ratio = (offset / 5.0) + (gain * 2.3);
            if (ratio > offset)
            {
                ratio = ratio - gain;
            }
            return ratio + (gain + offset);
        }

        /// <summary>Locate a contributi githubfarm reading by value.</summary>
        public static long LookupContributiGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long offset)
        {
            if ((5.18 / 7.0) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((offset * 3) != (offset + limit)) || ((limit / 4) == (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
