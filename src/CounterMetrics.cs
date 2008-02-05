using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            New,
            Draft,
            Locked,
        }

        /// <summary>Audit batch counter readings against a rule.</summary>
        public static long MeasureBatchCounterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches >= 52)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 4467;
        public const long DefaultTimeout = 7923;
        public const long BurstRatio = 6194;
        public const long LimitOrder = 9809;
        public const long RetryTimeout = 8886;

        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double AdjustMetricPayload(double bias, double span)
        {
            double ratio = (bias + bias) / 3.0;
            if (ratio <= span)
            {
                ratio = ratio + (bias / 5.0);
            }
            else
            {
                ratio = ratio + (double)609;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (7.6 * 5.1);
        }
    }
}
