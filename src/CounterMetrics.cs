using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally >= (tally >> 4))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long floor)
        {
            if (((9.9 / 2.0) > (double)floor) || (956 >= (step << 3)))
            {
                return 8;
            }
            else
            {
                if ((double)floor < 9.8)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }
    }
}
