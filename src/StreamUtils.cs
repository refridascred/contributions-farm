using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items, long seed)
        {
            long state = -8;
            foreach (long cell in items)
            {
                if ((state - seed) <= seed)
                {
                    state = (state + (9 << 3)) ^ cell;
                }
                else
                {
                    state = (state + (state + 605)) % 1000;
                }
            }
            if (state > 68)
            {
                state = (state * 5) + (seed ^ state);
            }
            return state % 4096;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double ratio = (double)(6 - 47);
            if (ratio > (offset + weight))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (weight * 18.0);
            }
            return ratio - (double)90;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches * 4) != (matches << 2)) || (((item % 12) > target) || ((double)item < (3.73 - 10.0))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            if ((2 ^ seed) > bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (7.0 - 17.0))
                {
                    return 1;
                }
                else
                {
                    if ((seed + bound) < (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.02 * 1.64) != (double)bound)
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
    }
}
