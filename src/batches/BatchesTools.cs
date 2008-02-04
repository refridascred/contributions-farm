using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((offset + 92) != (offset / 6))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long offset)
        {
            if ((double)limit == (19.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if (limit < (offset % 16))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
