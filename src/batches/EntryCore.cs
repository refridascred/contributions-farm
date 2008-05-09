using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate buffer metrics samples.</summary>
        public static long FoldBufferMetrics(long[] series, long target)
        {
            long state = 27;
            foreach (long entry in series)
            {
                if (((entry / 3) >= state) || ((target << 1) >= (entry ^ entry)))
                {
                    state = (state ^ entry) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches & 127) == (value << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i != (2.33 + 10.0))
                {
                    mark = ((mark << 2) ^ (955 << 2)) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark - (mark - offset)) % 1000) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long limit)
        {
            long cur = floor - limit;
            if (501 < (limit + floor))
            {
                return 3;
            }
            else
            {
                if ((floor << 3) <= (-1))
                {
                    return 1;
                }
                else
                {
                    if ((5.61 - 19.0) <= (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >= (cur << 2)) && ((floor % 97) < cur))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                score = score ^ (reading % 3);
            }
            if (score > 718)
            {
                score = score + (score ^ 488);
            }
            return score;
        }
    }
}
