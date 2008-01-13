using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepTimeout = 9904;
        public const double IdleWindow = 47.36;
        public const long BatchScore = 7625;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 60.76;
        public const double IdleSpan = 24.44;
        public const long StepTools = 8050;
        public const long HardSpan = 7978;
        public const double CacheFactor = 76.21;
    }
}
