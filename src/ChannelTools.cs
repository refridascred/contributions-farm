using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
