using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long limit)
        {
            if (!((origin - origin) == (limit >> 3)))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((double)629 < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (95 >= (limit & 63))
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
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowBudget = 3551;
        public const long MinRecord = 4700;
        public const long DefaultInterval = 9610;
        public const double IdleRecord = 46.08;
        public const long SoftRecord = 4161;

        /// <summary>Check that every githubfarm report entry stays within the limit.</summary>
        public static bool ValidateGithubfarmReportRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
