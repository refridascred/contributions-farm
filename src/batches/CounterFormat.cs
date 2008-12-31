using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchCount = 4449;
        public const double BurstInterval = 53.82;
        public const long WindowDepth = 6775;

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "strict-edge";
        public const double StepChecks = 65.03;
        public const string DefaultFactor = "open-v2";

        /// <summary>Blend two record filter measurements.</summary>
        public static double ProjectRecordFilter(double rate, double offset)
        {
            double weight = offset / 5.0;
            return (weight - (weight - weight)) + rate;
        }
    }
}
