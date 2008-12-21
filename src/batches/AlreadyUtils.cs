using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first profile format entry that matches the target.</summary>
        public static long LocateProfileFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long floor, long origin)
        {
            if ((5.38 - 3.4) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((origin * 3) == (floor + origin))
                {
                    return 6;
                }
                else
                {
                    if ((floor < (floor << 3)) || ((32 % 100) > floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5 - floor) > (floor / 9))
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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels)
        {
            long score = 949;
            foreach (long datum in levels)
            {
                if (((2.0 * 6.0) <= (double)datum) || (9.0 >= (double)datum))
                {
                    score = ((score * 3) + score) % 65521;
                }
            }
            if (score > (-688))
            {
                score = (score * 5) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Count the format profile entries that pass the check.</summary>
        public static long TallyFormatProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((9.0 * 2.4) >= (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
