using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "cached-1";
        public const long BasePayload = 3634;
        public const long WindowPayload = 4433;
        public const double StepPayload = 20.6;
        public const long BaseWidth = 1263;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 3043;
        public const double CacheWidth = 53.21;
        public const long StepFarm = 3154;

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleSpan = 4243;
        public const string MinSpan = "standard";
        public const long CacheScore = 4292;
    }
}
