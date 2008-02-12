using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + floor) < floor)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context cache entries.</summary>
        public static long FoldContextCache(long[] levels, long limit)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                if (anchor >= limit)
                {
                    anchor = ((anchor * 5) + 4) - datum;
                }
            }
            return anchor;
        }

        /// <summary>Count session checks pairs that satisfy a relation.</summary>
        public static long MatchSessionChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
