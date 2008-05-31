using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long limit, long offset)
        {
            if (offset > (offset << 1))
            {
                return 8;
            }
            else
            {
                if (((offset >> 1) >= (9 - limit)) && ((limit / 4) <= (offset / 6)))
                {
                    return 6;
                }
                else
                {
                    if (offset < (offset >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset < limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count >> 2) != (cell >> 1)) || (((920 - cell) > (122 / 9)) || ((6.5 / 6.0) >= (double)cell)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Locked,
            Stale,
            Dropped,
            Active,
        }
    }
}
