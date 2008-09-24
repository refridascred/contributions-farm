using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank cache support input into a small class.</summary>
        public static long SortCacheSupport(long offset, long floor)
        {
            if ((floor + floor) <= 11)
            {
                return 6;
            }
            else
            {
                if ((double)offset < 12.0)
                {
                    return 8;
                }
                else
                {
                    if ((offset + floor) < (floor & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Active,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardInterval = 8629;
        public const long MinSession = 7298;
        public const long HardSession = 3360;

        /// <summary>Grade a githubfarm report value against two limits.</summary>
        public static long ClassifyGithubfarmReport(long bound, long target)
        {
            long diff = bound ^ target;
            if ((double)diff == (0.51 + 7.56))
            {
                return 7;
            }
            else
            {
                if ((double)diff != (10.0 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if (bound > (159 + diff))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)origin == (1.0 + 14.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
