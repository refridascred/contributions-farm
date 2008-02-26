using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next stats farm value from a seed.</summary>
        public static long SeriesStatsFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                if (2.63 > (double)anchor)
                {
                    anchor = (anchor - target) % 4096;
                }
                else
                {
                    anchor = (anchor - ((long)i - anchor)) % 255;
                    anchor = ((anchor << 2) ^ ((long)i + target)) % 1000;
                }
                if ((anchor / 7) <= (target << 1))
                {
                    anchor = anchor ^ 1;
                }
                if ((anchor % 24) > target)
                {
                    anchor = ((anchor * 4) + (target & 63)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long mark = 433;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark * 3) + (item << 2)) % 4096) - (long)i;
                }
                mark = mark - (mark * 5);
            }
            if (mark > 5)
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits >> 3) <= offset)
                {
                    hits = (hits + 1) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
