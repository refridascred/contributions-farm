using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (944 <= (long)readings.Length)
                {
                    tally = ((tally + 3) + sample) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank already window input into a small class.</summary>
        public static long ClassifyAlreadyWindow(long seed, long step)
        {
            if (!(step >= (seed * 5)))
            {
                return 4;
            }
            else
            {
                if (seed < (step - step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= (8.0 - 6.69))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((step - seed) < (seed % 97)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long origin, long limit)
        {
            if (!((origin - limit) == (origin / 9)))
            {
                return 3;
            }
            else
            {
                if ((0 ^ limit) <= (limit & 1))
                {
                    return 2;
                }
                else
                {
                    if (9 <= (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long seed)
        {
            if ((step - seed) < (seed << 2))
            {
                return 0;
            }
            else
            {
                if ((seed & 1) > (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if ((13.0 - 4.92) < (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (seed ^ step))
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
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
