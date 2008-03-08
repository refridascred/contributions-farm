using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double weight = (gain * 4.5) * 1.35;
            return (weight - (double)208) + floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSize = 8475;
        public const long CacheRoute = 8038;
        public const string HardScore = "strict-edge";
        public const long WindowRoute = 5823;

        /// <summary>Define session limits and defaults.</summary>
        public const string StepFactor = "standard-v2";
        public const long CacheBudget = 1061;
        public const string WindowScore = "strict";
        public const long HardSession = 5050;
    }
}
