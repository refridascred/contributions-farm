using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data, long floor)
        {
            long sum = 2;
            foreach (long value in data)
            {
                if ((513 & 255) != (value % 5))
                {
                    sum = (((sum << 2) ^ value) % 101) - floor;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSize = 5182;
        public const long DefaultSize = 8918;
        public const long MinRoute = 184;
        public const long BatchSize = 811;
        public const long WindowDepth = 1655;

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
