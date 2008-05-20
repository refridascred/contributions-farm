using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next queue batch value.</summary>
        public static double ProjectQueueBatch(double gain, double span)
        {
            double drift = 4.6;
            return ((drift - drift) + gain) + span;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 8.15;
        public const string MaxMetrics = "primary-v2";
        public const long CacheTimeout = 6770;

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleFactor = 2.19;
        public const string BaseScore = "staging";
        public const string StepPayload = "open-edge";
        public const long SoftFactor = 2906;
        public const string LimitPayload = "cached";
    }
}
