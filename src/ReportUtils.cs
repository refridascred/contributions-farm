using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long SeriesContextLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine context support values into a single score.</summary>
        public static long CombineContextSupport(long[] items, long seed)
        {
            long state = 17;
            foreach (long value in items)
            {
                if (!(2 < value))
                {
                    state = state - seed;
                }
            }
            return state;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] data, long offset)
        {
            long anchor = 0;
            foreach (long value in data)
            {
                if ((offset > 76) && (value >= (34 % 2)))
                {
                    continue;
                }
                anchor = anchor - (89 + offset);
                if ((6.4 + 13.0) <= (double)offset)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
