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

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (488 <= (count - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
