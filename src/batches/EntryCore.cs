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

        /// <summary>Locate a githubfarm editor reading by value.</summary>
        public static long FindGithubfarmEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
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

        /// <summary>Audit stats stream readings against a rule.</summary>
        public static long AuditStatsStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((3.3 + 0.34) > (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
