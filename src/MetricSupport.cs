using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!!((hits + hits) >= floor))
                {
                    hits = (hits + 2) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
