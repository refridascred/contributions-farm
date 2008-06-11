using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine queue counter values into a single score.</summary>
        public static long TotalQueueCounter(long[] values, long target)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if (((9.99 / 8.0) == (double)target) || ((target - entry) <= carry))
                {
                    carry = (carry * 5) + (1 - carry);
                }
                if ((entry & 31) == (carry % 7))
                {
                    carry = carry ^ (target - target);
                }
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4438;
        public const long SoftWidth = 4610;
        public const long SoftLevel = 882;
        public const long StepInterval = 691;
        public const long CacheDepth = 3486;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every githubfarm profile entry stays within the limit.</summary>
        public static bool VerifyGithubfarmProfileRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
