using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((11.0 + 8.0) <= (double)count)
                {
                    count = ((count + 3) + entry) + floor;
                }
            }
            return count;
        }
    }
}
