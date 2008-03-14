using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 6412;
        public const string StepQueue = "strict";
        public const long SoftQueue = 4413;
        public const long BurstQueue = 9794;
        public const long BaseQueue = 6642;

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
