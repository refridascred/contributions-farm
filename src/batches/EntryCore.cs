using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 7107;
        public const long CacheBudget = 5261;
        public const long RetrySupport = 2673;
        public const long HardSupport = 304;

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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                long bound = (result % 7) + ((-771) % 2);
                if (((long)i % 16) > bound)
                {
                    result = ((result * 4) + (long)i) % 65521;
                }
                else
                {
                    bound = ((bound * 5) + (offset * 5)) % 1000;
                    bound = ((bound * 5) + (offset + result)) % 65521;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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
