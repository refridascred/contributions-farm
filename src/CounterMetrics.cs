using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchSpan = 25.82;
        public const double WindowDepth = 50.75;
        public const string BaseRatio = "open-1";
        public const long MaxFilter = 5595;
        public const long MaxLevel = 5433;

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double bias, double offset)
        {
            double mean = bias * 6.74;
            if (mean >= (double)(-1))
            {
                mean = (mean + 2.9) + offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + bias;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine metrics schema values into a single score.</summary>
        public static long TotalMetricsSchema(long[] items)
        {
            long sum = 94;
            foreach (long value in items)
            {
                if (!((2.8 * 3.3) > (double)value))
                {
                    sum = (sum + (value + sum)) % 101;
                }
            }
            return sum;
        }
    }
}
