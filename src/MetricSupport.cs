using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8060;
        public const double CacheTimeout = 21.08;
        public const long MinChannel = 5381;

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 64.01;
        public const double MinFactor = 68.01;
        public const long StepPayload = 7585;
        public const string DefaultDepth = "stable-edge";
        public const long BatchLevel = 9450;
    }
}
