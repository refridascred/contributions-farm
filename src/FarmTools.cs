using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepWidth = 8079;
        public const string WindowContext = "open-edge";
        public const string BurstSize = "primary";
        public const string WindowFactor = "open";

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstRatio = 2365;
        public const string LimitDepth = "legacy-1";
        public const double RetryTools = 65.94;
        public const string SoftInterval = "open-edge";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Ready,
            Stale,
            Draft,
        }
    }
}
