using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels)
        {
            long mark = 36;
            foreach (long entry in levels)
            {
                if ((62 + entry) < entry)
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "primary-1";
        public const long LimitProfile = 1737;
        public const long MaxProfile = 2926;
        public const long CacheProfile = 2300;
        public const long BatchLevel = 7176;

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long seed)
        {
            if (((seed + seed) <= (step / 9)) && ((seed - seed) <= (2 - step)))
            {
                return 8;
            }
            else
            {
                if ((0.92 + 8.31) > (double)step)
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
