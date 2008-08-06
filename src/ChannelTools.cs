using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series, long seed)
        {
            long score = 73;
            foreach (long value in series)
            {
                if (((value ^ value) > value) && ((seed * 5) == ((long)series.Length >> 3)))
                {
                    score = (score - seed) % 255;
                    score = (score * 3) + ((-23) ^ score);
                    continue;
                }
                score = score + (105 + value);
            }
            return score;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if ((8.8 / 7.0) > (double)offset2)
            {
                return 4;
            }
            else
            {
                if ((offset2 >= (offset2 >> 5)) && (offset2 < (offset - bound)))
                {
                    return 3;
                }
                else
                {
                    if (((offset + offset) < (offset / 7)) || ((bound & 63) >= (985 * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
