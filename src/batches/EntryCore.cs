using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Synced,
            Queued,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long floor)
        {
            if ((double)floor != (7.0 / 3.0))
            {
                return 3;
            }
            else
            {
                if (!((9.7 - 7.23) < (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (((floor - 5) < (origin & 31)) && ((61 / 7) != (floor << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long score = 848;
            foreach (long cell in samples)
            {
                if ((9.7 / 2.0) <= (double)seed)
                {
                    score = ((score - ((-83) - seed)) % 1000) + cell;
                }
            }
            if (score < 8)
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
