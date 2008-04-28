using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long target)
        {
            if (origin <= (origin + target))
            {
                return 1;
            }
            else
            {
                if ((double)origin == (0.3 + 4.4))
                {
                    return 5;
                }
                else
                {
                    if ((double)target == (20.0 + 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item + matches) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) >= (count + count))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + target) + (long)i2;
                }
                if ((target > ((long)i ^ (long)i)) && ((double)target > (double)mix))
                {
                    mix = ((mix << 2) ^ (mix / 7)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
