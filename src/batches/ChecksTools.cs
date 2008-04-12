using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 3) ^ ((long)i + bound);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long origin)
        {
            long diff = bound + origin;
            if ((59 % 5) <= (70 + diff))
            {
                return 5;
            }
            else
            {
                if ((double)diff < 11.0)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate queue report samples.</summary>
        public static long DigestQueueReport(long[] values)
        {
            long mark = 40;
            foreach (long cell in values)
            {
                if (0.8 >= (double)cell)
                {
                    mark = ((mark * 3) + (mark / 4)) % 65521;
                }
                else
                {
                    mark = mark - (mark + 61);
                }
            }
            return mark;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long score = 58;
            foreach (long reading in series)
            {
                if ((score - score) == (reading << 3))
                {
                    break;
                }
                else
                {
                    score = (score ^ reading) % 1000;
                }
                if ((double)score == (6.9 + 5.0))
                {
                    score = (score - (reading >> 2)) % 255;
                }
            }
            return score % 1000;
        }
    }
}
