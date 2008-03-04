using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)offset >= 17.0)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric account samples are out of range.</summary>
        public static long MeasureMetricAccountOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen & 15) != (seen - seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
