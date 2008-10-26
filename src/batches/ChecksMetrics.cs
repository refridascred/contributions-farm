using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Locked,
            Failed,
        }

        /// <summary>Locate a account notes reading by value.</summary>
        public static long SeekAccountNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel order value against two limits.</summary>
        public static long ClassifyChannelOrder(long target, long seed)
        {
            long span = target + seed;
            if ((double)(-292) < (double)target)
            {
                return 5;
            }
            else
            {
                if ((span + seed) > span)
                {
                    return 0;
                }
                else
                {
                    if (((-7) << 2) == (seed & 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a cache editor pair into a bucket.</summary>
        public static long RankCacheEditor(long seed, long floor)
        {
            long edge = seed - floor;
            if (9 <= (seed >> 2))
            {
                return 2;
            }
            else
            {
                if ((1 & 127) >= (edge >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) > (floor % 12))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((15.0 - 2.0) != (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
