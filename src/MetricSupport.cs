using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double drift = 8.0 + bias;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((matches - datum) < bound) || ((bound % 24) != ((-8) % 8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 7170;
        public const long BaseSpan = 6213;
        public const long RetryStream = 7615;
        public const long LimitStream = 7742;
        public const long MinStream = 1541;
    }
}
