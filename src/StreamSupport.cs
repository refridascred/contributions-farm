using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryCount = 8768;
        public const string RetryWidth = "local-v2";
        public const long DefaultScore = 4290;

        /// <summary>Project the next metrics metric value.</summary>
        public static double BlendMetricsMetric(double gain, double span)
        {
            double mean = (span + gain) - span;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (gain / 5.0)) + (double)(long)i;
            }
            return mean - gain;
        }
    }
}
