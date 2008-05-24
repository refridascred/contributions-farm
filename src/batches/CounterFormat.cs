using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of format session readings.</summary>
        public static long DigestFormatSession(long[] readings, long step)
        {
            long sum = 60;
            foreach (long item in readings)
            {
                if ((24 > (item + item)) || ((426 >> 3) < (sum << 3)))
                {
                    sum = (sum + item) % 255;
                }
                if ((sum >> 3) > step)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 54;
            foreach (long value in levels)
            {
                if (!((value >> 3) <= (value + score)))
                {
                    score = (score ^ (45 / 9)) % 4096;
                }
                if (538 > (score / 5))
                {
                    break;
                }
            }
            if (score < 48)
            {
                score = (score - (score ^ 523)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long offset)
        {
            if (origin >= (47 - origin))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= (9.84 - 5.85))
                {
                    return 1;
                }
                else
                {
                    if ((1.52 / 6.0) > (double)origin)
                    {
                        return 3;
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
