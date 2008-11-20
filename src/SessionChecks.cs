using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ (long)i;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long limit, long limit2)
        {
            if (1 < limit2)
            {
                return 1;
            }
            else
            {
                if ((limit2 * 5) == (limit2 + 857))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of already stream entries.</summary>
        public static long FoldAlreadyStream(long[] samples)
        {
            long mark = 8;
            foreach (long entry in samples)
            {
                if ((double)entry < (0.9 - 14.0))
                {
                    mark = ((mark * 5) + (entry - mark)) % 65521;
                }
            }
            return mark;
        }
    }
}
