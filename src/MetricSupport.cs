using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double LimitTimeout = 43.01;
        public const double IdleSupport = 45.15;
        public const long RetrySupport = 3427;
        public const double LimitRatio = 45.61;
        public const long BaseCount = 481;

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 2314;
        public const long BurstOrder = 7623;
        public const string SoftOrder = "primary-1";
        public const long StepRatio = 4587;
        public const long WindowOrder = 908;

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = ((sum << 3) ^ (sum / 9)) % 1000;
                if (((sum + value) < sum) && ((double)value == (1.34 - 9.18)))
                {
                    sum = sum ^ (value % 60);
                }
                if ((double)value > (double)sum)
                {
                    break;
                }
            }
            if (sum > 247)
            {
                sum = (sum << 2) ^ (sum * 4);
            }
            return sum % 97;
        }
    }
}
