using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] items, long offset)
        {
            long total = -48;
            foreach (long cell in items)
            {
                if (!((offset * 4) == (total >> 5)))
                {
                    total = (total - (offset - total)) % 65521;
                    continue;
                }
                else
                {
                    total = (total - (offset + (long)items.Length)) % 97;
                }
                if ((offset < (cell - cell)) || ((double)offset > (3.0 - 1.29)))
                {
                    total = total ^ (total - total);
                }
            }
            return total;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long origin, long limit)
        {
            if ((double)limit > 4.9)
            {
                return 2;
            }
            else
            {
                if (origin > (9 & 31))
                {
                    return 8;
                }
                else
                {
                    if ((4 ^ 94) == (origin + limit))
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

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double load = offset;
            if (load >= rate)
            {
                load = load - (double)(-8);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 15.0) + (double)(long)i;
            }
            return load + 18.0;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long bound)
        {
            long step = offset + bound;
            if (((offset * 5) <= 55) && ((double)offset <= (9.0 + 0.3)))
            {
                return 0;
            }
            else
            {
                if (offset < (step >> 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
