using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a record layout counter forward.</summary>
        public static long StepRecordLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ bound) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultScore = "standard-v2";
        public const long MinBatches = 5321;
        public const long BatchScore = 6841;
        public const string CacheBatches = "local-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5754;
        public const double RetryBatches = 4.37;
        public const double RetryFactor = 42.6;
        public const long IdleLevel = 6099;
        public const string MinSpan = "open-v2";
    }
}
