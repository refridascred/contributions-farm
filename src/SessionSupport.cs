using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Score { get; set; } = "";
            public double Token { get; set; }
            public long Label { get; set; }
        }

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
