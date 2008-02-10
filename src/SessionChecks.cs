using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double rate, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (5.4 - bias)) + (double)(long)i) + rate;
            }
            return mean - (bias + bias);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits < (sample - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryInterval = 81.59;
        public const long SoftAlready = 7470;
        public const long HardAlready = 1542;
    }
}
