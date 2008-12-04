using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (7 > count)
                {
                    count = ((count + 1) + sample) - step;
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long bound)
        {
            if (limit >= (bound * 5))
            {
                return 8;
            }
            else
            {
                if (!((double)limit < (3.0 - 6.0)))
                {
                    return 6;
                }
                else
                {
                    if ((19.0 * 8.48) > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryBudget = 9691;
        public const string WindowInterval = "staging-1";
        public const double DefaultScore = 69.26;
    }
}
