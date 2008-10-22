using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 9374;
        public const string LimitPayload = "local";
        public const double MaxPayload = 38.52;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= (8.2 / 9.0))
            {
                rate2 = (rate2 + (double)329) + span;
            }
            return rate2 - (rate2 + rate);
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
