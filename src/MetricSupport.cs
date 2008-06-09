using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5793;
        public const double RetryScore = 28.61;
        public const string DefaultChecks = "primary";

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long floor)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = ((acc << 2) ^ (sample << 3)) - floor;
            }
            if (acc < (-367))
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultInterval = 73.18;
        public const string StepBuffer = "fallback";
        public const double MinBuffer = 66.59;
        public const long MaxBuffer = 9564;
        public const double IdleBuffer = 26.3;
    }
}
