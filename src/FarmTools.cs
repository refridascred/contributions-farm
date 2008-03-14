using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "legacy-1";
        public const double StepLevel = 72.55;
        public const string WindowDepth = "local-edge";
        public const double WindowTimeout = 14.78;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "strict-v2";
        public const long MaxCache = 9877;
        public const string RetryDepth = "latest-1";
        public const long BatchTimeout = 9445;
    }
}
