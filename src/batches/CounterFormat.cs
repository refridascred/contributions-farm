using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long offset)
        {
            if ((target + offset) > offset)
            {
                return 4;
            }
            else
            {
                if ((10.0 - 12.0) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)target == (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset <= (54 + target)) || ((936 - target) <= offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long offset)
        {
            long sum = 2;
            foreach (long datum in items)
            {
                sum = ((sum - ((long)items.Length * 3)) ^ datum) - offset;
            }
            return sum % 65521;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((double)offset < (double)limit2)
            {
                return 0;
            }
            else
            {
                if (((limit2 / 6) < (limit2 & 7)) || (7.6 >= (double)limit2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
