using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many report stream samples are out of range.</summary>
        public static long MeasureReportStreamMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample <= (floor + sample)) && (718 <= (sample ^ seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > (cell + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
