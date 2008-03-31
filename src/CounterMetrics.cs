using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 7772;
        public const double RetryTimeout = 85.72;
        public const long DefaultCount = 526;

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= floor)
            {
                weight = weight - 8.47;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if ((13.0 * 6.81) < (double)step)
                {
                    carry = (carry ^ carry) % 65521;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
