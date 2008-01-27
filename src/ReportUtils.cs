using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches << 2) <= (sample - matches))
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 7295;
        public const long MaxCache = 2663;
        public const long DefaultBudget = 2754;

        /// <summary>Validate contributi session readings against a bound.</summary>
        public static bool CheckContributiSessionRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate cache cluster samples.</summary>
        public static long ScoreCacheCluster(long[] samples, long limit)
        {
            long carry = 38;
            foreach (long datum in samples)
            {
                if ((519 << 1) < (carry - datum))
                {
                    carry = (carry - (datum ^ datum)) % 97;
                }
                else
                {
                    carry = carry ^ (84 >> 4);
                }
            }
            if (carry > 791)
            {
                carry = (carry << 3) ^ limit;
            }
            return carry;
        }
    }
}
