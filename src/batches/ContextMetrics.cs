using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultWidth = 18.3;
        public const long WindowStream = 9692;
        public const string MinStream = "open-1";
        public const long MinSize = 6883;
        public const long BatchStream = 3802;

        /// <summary>Define format limits and defaults.</summary>
        public const double StepBudget = 50.0;
        public const long LimitRatio = 9787;
        public const string LimitFormat = "fallback";
        public const double CacheFormat = 85.6;

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "staging-edge";
        public const long BatchQueue = 4942;
        public const long HardRatio = 1087;
        public const long StepQueue = 1791;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitBudget = 6510;
        public const double BurstLevel = 76.34;
        public const long BurstCache = 3290;
        public const double HardCache = 27.63;
    }
}
