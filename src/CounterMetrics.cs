using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(matches >= (59 + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double bias, double floor)
        {
            double mean = floor - (double)556;
            if (mean < mean)
            {
                mean = (mean + (mean * 17.0)) + bias;
            }
            return mean - mean;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long floor)
        {
            long prev = origin ^ floor;
            if ((floor + origin) < 0)
            {
                return 2;
            }
            else
            {
                if ((prev & 3) > floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a tools cluster reading.</summary>
        public static double ScaleToolsCluster(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - ratio) + floor;
        }
    }
}
