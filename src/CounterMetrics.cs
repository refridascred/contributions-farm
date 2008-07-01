using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double bias)
        {
            double weight = (bias / 5.0) * 8.0;
            if (weight >= (rate / 3.0))
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + bias;
        }

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
