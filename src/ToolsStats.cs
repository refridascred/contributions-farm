using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long origin)
        {
            long gap = target + origin;
            if (31 < (origin - target))
            {
                return 8;
            }
            else
            {
                if (!(origin < (origin / 2)))
                {
                    return 0;
                }
                else
                {
                    if ((gap >> 1) == (origin - 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate metrics contributi samples.</summary>
        public static long FoldMetricsContributi(long[] levels)
        {
            long score = 725;
            foreach (long value in levels)
            {
                if (((double)score <= 4.8) || ((value + score) > (score % 64)))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = ((score * 4) + (value / 4)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)tally > (4.4 * 4.0)) || ((double)sample > (5.9 + 8.15)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((-5) + seed) <= (acc & 1))
                {
                    acc = (acc ^ (long)i) % 1000;
                    break;
                }
                acc = (acc * 2) + (seed ^ acc);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a session entry reading by value.</summary>
        public static long LookupSessionEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
