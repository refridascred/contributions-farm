using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > (double)tally)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer commits input into a small class.</summary>
        public static long BucketBufferCommits(long bound, long offset)
        {
            if ((offset / 8) < (offset + offset))
            {
                return 7;
            }
            else
            {
                if (!((double)bound <= (5.4 * 7.8)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
