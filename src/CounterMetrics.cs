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

        /// <summary>Match up farm token samples.</summary>
        public static long CompareFarmTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
