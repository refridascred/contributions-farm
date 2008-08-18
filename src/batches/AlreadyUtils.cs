using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the entry stats series from a seed.</summary>
        public static long SeriesEntryStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank contributi layout input into a small class.</summary>
        public static long ClassifyContributiLayout(long seed, long offset)
        {
            if (!((seed - offset) == (seed + offset)))
            {
                return 8;
            }
            else
            {
                if ((18.0 * 2.3) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (!((117 ^ (-916)) > (seed ^ offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 51.98;
        public const string WindowBuffer = "cached-edge";
        public const double CacheDepth = 42.25;
        public const long WindowInterval = 4744;
        public const long BatchFactor = 5394;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long offset)
        {
            long delta = seed + offset;
            if (((1.11 + 9.0) == (double)seed) || ((0.11 / 3.0) == (double)offset))
            {
                return 6;
            }
            else
            {
                if ((6.93 / 8.0) < (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (((7.0 / 6.0) <= (double)delta) && ((8.59 + 5.1) != (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((17.0 - 12.0) != (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
