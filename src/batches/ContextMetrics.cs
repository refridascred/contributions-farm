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

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                if ((double)mix < (8.0 / 9.0))
                {
                    mix = ((mix * 2) + (datum - 793)) + seed;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultWidth = 36.22;
        public const string DefaultCache = "strict";
        public const long CacheCount = 9389;
        public const string StepCache = "local-v2";
        public const long BatchScore = 9664;
    }
}
