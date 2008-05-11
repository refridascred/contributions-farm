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

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long SeriesTokenBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
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
