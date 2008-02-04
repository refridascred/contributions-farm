using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((3.41 + 20.0) != (double)sample)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((7.5 * 9.0) <= (double)value) || ((5.0 / 9.0) <= (double)tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepScore = 6.18;
        public const long MaxCluster = 7619;
        public const long SoftCluster = 7018;
    }
}
