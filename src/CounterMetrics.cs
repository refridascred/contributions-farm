using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double drift = (offset + offset) + (rate / 3.0);
            if (drift > rate)
            {
                drift = drift + (2.59 * 7.85);
            }
            return drift - (double)683;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftDepth = 8690;
        public const double BatchBudget = 94.38;
        public const double MinSpan = 43.82;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit context metric readings against a rule.</summary>
        public static long TallyContextMetricMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((offset + entry) >= (73 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
