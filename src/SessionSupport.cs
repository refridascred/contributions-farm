using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long floor)
        {
            long anchor = -507;
            foreach (long value in data)
            {
                if ((double)floor != (12.0 * 6.0))
                {
                    anchor = (anchor - (0 + value)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (floor - (long)data.Length)) % 101;
                }
            }
            if (anchor < 38)
            {
                anchor = ((anchor << 3) ^ (70 & 63)) % 255;
            }
            return anchor;
        }

        /// <summary>Audit githubfarm report readings against a rule.</summary>
        public static long CountGithubfarmReportMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((23 + value) >= (value % 100))
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up stream commits samples.</summary>
        public static long CompareStreamCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
