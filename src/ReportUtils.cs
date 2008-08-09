using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3689;
        public const long LimitPayload = 7487;
        public const string MinPayload = "fallback-1";
        public const double CachePayload = 26.8;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 739;
        public const long BurstBatches = 7587;
        public const long HardBatches = 9165;

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 766;
        public const double WindowMetric = 43.7;
        public const string DefaultSpan = "standard-edge";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((8.0 - 12.0) >= (double)offset)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Project the next metric command value.</summary>
        public static double ProjectMetricCommand(double ratio, double floor)
        {
            double gain = (double)(8 + 449);
            if (gain > (gain / 9.0))
            {
                gain = (gain - ratio) + floor;
            }
            return gain + (ratio / 7.0);
        }
    }
}
