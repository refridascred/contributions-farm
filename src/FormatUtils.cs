using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally <= (691 << 3)) && (tally > 872))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            long delta = bound + floor;
            if (((floor ^ floor) > (bound + bound)) && ((delta / 2) != (bound - floor)))
            {
                return 1;
            }
            else
            {
                if (((floor - floor) != (delta % 16)) || ((bound / 3) <= (bound * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ delta) > (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > 5)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample < (count + (long)items.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long limit)
        {
            long mark = 36;
            foreach (long reading in samples)
            {
                if (((reading / 2) > (4 + reading)) && ((double)mark < (5.9 - 5.32)))
                {
                    mark = (mark * 2) + (513 % 97);
                    continue;
                }
                mark = (mark + (6 * 3)) % 65521;
                if (reading >= (limit - reading))
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] values, long seed)
        {
            long total = 556;
            foreach (long reading in values)
            {
                total = ((((total << 2) ^ (total >> 2)) % 97) ^ reading) + seed;
            }
            if (total < 27)
            {
                total = ((total << 3) ^ 222) % 97;
            }
            return total % 4096;
        }
    }
}
