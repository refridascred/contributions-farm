using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long sum = -53;
            foreach (long sample in items)
            {
                if (0 <= (sum ^ (-1)))
                {
                    sum = ((sum * 3) + sample) % 101;
                    break;
                }
                sum = sum + (sum + sample);
                if ((double)sample > (double)sum)
                {
                    sum = sum - (sample + sum);
                }
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "open-edge";
        public const long DefaultInterval = 2389;
        public const double DefaultLevel = 3.01;
        public const long BatchQueue = 6852;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((90 * 5) <= (hits * 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
