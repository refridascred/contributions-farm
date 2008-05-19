using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((offset % 60) > (offset + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((floor + count) >= (24 + cell)) && (((floor + 2) <= (cell - floor)) && ((floor - floor) != (6 - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
