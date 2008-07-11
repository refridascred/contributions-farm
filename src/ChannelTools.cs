using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings, long limit)
        {
            long sum = 569;
            foreach (long reading in readings)
            {
                sum = (sum + (limit + limit)) % 4096;
                if (((limit - limit) > (reading & 31)) || ((limit << 2) == ((-767) * 2)))
                {
                    sum = (sum - (reading - sum)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + limit) % 255;
                }
            }
            return sum;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long target)
        {
            long cur = bound - target;
            if ((double)target == (8.2 * 3.2))
            {
                return 1;
            }
            else
            {
                if ((cur >> 2) < bound)
                {
                    return 4;
                }
                else
                {
                    if (((cur ^ cur) != (cur + bound)) && ((double)cur >= (9.5 - 1.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
