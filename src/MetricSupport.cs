using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of format buffer entries.</summary>
        public static long CombineFormatBuffer(long[] samples)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (1.6 + 7.8))
                {
                    score = (score * 3) + (score - score);
                }
                else
                {
                    score = (score - (entry % 24)) % 101;
                }
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count >= (bound % 64)) || ((count / 5) >= (77 + count)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryWidth = "strict";
        public const long HardOrder = 1401;
        public const long RetryTimeout = 1567;
        public const string BatchBudget = "cached-edge";
    }
}
