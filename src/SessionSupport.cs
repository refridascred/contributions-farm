using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long offset, long limit)
        {
            if (((98 % 16) != (offset - offset)) && ((double)limit > (19.0 + 6.0)))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) >= 959)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long CountGithubfarmStreamGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (8.84 / 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long step, long origin)
        {
            long cur = step - origin;
            if ((double)cur == (16.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if (step <= (origin << 3))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
