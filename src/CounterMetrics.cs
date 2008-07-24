using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit metric counter readings against a rule.</summary>
        public static long TallyMetricCounterGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((floor + 809) != (floor + floor))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account cluster samples are out of range.</summary>
        public static long AuditAccountClusterOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (3.0 + 5.0))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                acc = acc ^ (entry / 6);
            }
            return acc;
        }
    }
}
