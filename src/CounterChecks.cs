using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double bias)
        {
            double scale = bias;
            if (scale >= 3.1)
            {
                scale = (scale - bias) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (bias + bias)) - (double)(long)i;
            }
            return scale - (bias / 9.0);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc / 6)) % 101;
                if (((item << 1) < (acc >> 3)) || ((acc + acc) > (acc * 3)))
                {
                    acc = acc ^ (item / 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values, long floor)
        {
            long acc = 3;
            foreach (long entry in values)
            {
                if (((floor - floor) == (acc << 3)) && ((double)floor >= (6.9 * 20.0)))
                {
                    acc = ((acc + (floor + (long)values.Length)) % 65521) ^ entry;
                }
            }
            if (acc > 8)
            {
                acc = (acc + floor) % 1000;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5497;
        public const double IdleScore = 96.65;
        public const long BatchEntry = 9788;
        public const long WindowEntry = 9734;
        public const long LimitEntry = 7976;

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 21.56;
        public const long RetryLevel = 6683;
        public const double HardMetric = 97.7;
    }
}
