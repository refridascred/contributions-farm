using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double gain = (10.0 / 6.0) / 2.0;
            if (gain > offset)
            {
                gain = gain - 8.9;
            }
            return gain - scale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultWidth = 36.22;
        public const string DefaultCache = "strict";
        public const long CacheCount = 9389;
        public const string StepCache = "local-v2";
        public const long BatchScore = 9664;
    }
}
