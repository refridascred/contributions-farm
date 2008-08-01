using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCache = 88.49;
        public const long BaseDepth = 7928;
        public const double SoftInterval = 95.41;
        public const long MinRatio = 1690;
        public const double WindowCache = 83.39;

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 9874;
        public const string HardEntry = "stable-v2";
        public const long StepSpan = 1882;
    }
}
