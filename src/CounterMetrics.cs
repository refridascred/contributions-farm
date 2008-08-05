using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long bound)
        {
            long score = 0;
            foreach (long item in readings)
            {
                if ((item << 1) >= score)
                {
                    score = (score - (item * 4)) - bound;
                }
            }
            return score % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long bound)
        {
            long result = 3;
            foreach (long datum in levels)
            {
                result = (((result * 2) + result) ^ datum) + bound;
            }
            return result;
        }

        /// <summary>Count the already schema entries that pass the check.</summary>
        public static long MeasureAlreadySchemaOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((15.0 * 5.83) <= (double)value)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
