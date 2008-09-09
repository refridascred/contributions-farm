using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a queue profile pair into a bucket.</summary>
        public static long RankQueueProfile(long bound, long limit)
        {
            if ((4.0 * 4.1) < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((3.08 / 6.0) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((limit % 8) < (limit + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool GuardRouteProfileBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((55 << 3) <= (item % 10))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long limit)
        {
            long gap = offset - limit;
            if (gap > (offset << 3))
            {
                return 8;
            }
            else
            {
                if (offset >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
