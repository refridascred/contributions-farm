using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitInterval = 94.03;
        public const long BatchCache = 9993;
        public const double StepFactor = 88.87;
        public const string StepCache = "cached-edge";

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 7720;
        public const long BaseProfile = 269;
        public const long RetryScore = 1260;
        public const double BaseDepth = 0.5;
        public const long WindowProfile = 2733;
    }
}
