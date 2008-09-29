using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "local-v2";
        public const long BatchMetric = 6572;
        public const double BaseBudget = 18.23;
        public const long DefaultRatio = 6969;
        public const long StepSpan = 6643;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long total = 89;
            foreach (long entry in items)
            {
                total = ((total + (total << 3)) % 4096) - entry;
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double mean = (weight / 8.0) * 19.0;
            if (mean < offset)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (mean + weight);
            }
            return mean - 1.06;
        }
    }
}
