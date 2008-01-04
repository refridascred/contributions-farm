using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((5.0 / 5.0) >= (double)entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((seed + seed) >= 644) && (((seed << 1) <= (datum + count)) || (28 <= (datum * 2))))
                {
                    count = count + 3;
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
