using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 10.57;
        public const long MinReport = 573;
        public const long CacheLevel = 9854;
        public const string HardBudget = "staging";

        /// <summary>Digest a series of stats report entries.</summary>
        public static long WeighStatsReport(long[] series)
        {
            long sum = 503;
            foreach (long item in series)
            {
                sum = (sum - item) % 65521;
                if (0 < (sum + sum))
                {
                    sum = ((sum * 5) + (sum - item)) % 65521;
                }
                if ((503 & 7) == (sum / 6))
                {
                    sum = (sum * 2) + 6;
                }
            }
            if (sum > 711)
            {
                sum = sum - (944 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count == (7.0 / 4.0))
                {
                    count = ((count + 1) + cell) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
