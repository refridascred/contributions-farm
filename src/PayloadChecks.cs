using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - value) == (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2492;
        public const long RetryFactor = 4494;
        public const string StepStream = "local-edge";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value >> 2) > (value / 7))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Locked,
            Queued,
            Ready,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultSpan = 24.57;
        public const long BurstWidth = 212;
        public const long BurstMetrics = 3225;
        public const long CacheScore = 4474;
        public const long StepMetrics = 6309;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double gain = bias;
            if (gain > (double)(-8))
            {
                gain = (gain + (double)96) - ratio;
            }
            return gain + (bias + 7.3);
        }
    }
}
