using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values, long limit)
        {
            long acc = 301;
            foreach (long datum in values)
            {
                acc = (((acc * 5) + limit) % 1000) ^ datum;
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a layout githubfarm sample.</summary>
        public static long SeekLayoutGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long target)
        {
            if (((double)step != (5.16 / 4.0)) || (((-300) + target) != (target & 15)))
            {
                return 7;
            }
            else
            {
                if ((double)step <= (9.0 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((3.0 + 0.1) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((98 % 5) >= (step + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseDepth = 7601;
        public const long LimitNotes = 1504;
        public const double IdleCount = 33.01;
        public const long MinBudget = 8502;
        public const long MaxNotes = 6767;
    }
}
