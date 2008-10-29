using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxScore = 6576;
        public const double RetryInterval = 13.54;
        public const double WindowSize = 88.93;
        public const long BatchSize = 3445;

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultSpan = "stable-1";
        public const double BurstSize = 72.35;
        public const long StepSpan = 378;
        public const long StepReport = 2345;

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSession = "primary-v2";
        public const long CacheScore = 9935;
        public const double DefaultCount = 9.66;
    }
}
