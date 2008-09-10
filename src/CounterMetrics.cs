using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) == (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double ratio = (double)75 * 20.0;
            if (ratio < (span + bias))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio / 3.0)) - (double)(long)i;
            }
            return ratio - (bias + bias);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long limit)
        {
            if ((0 - floor) != (floor - 426))
            {
                return 8;
            }
            else
            {
                if ((floor & 15) < (limit * 5))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 5396;
        public const double BaseBatches = 16.17;
        public const string BatchSize = "legacy-1";
        public const long MaxScore = 3785;
        public const long BatchBatches = 7969;
    }
}
