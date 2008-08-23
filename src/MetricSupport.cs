using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Ready,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxScore = 18.61;
        public const long WindowContext = 3759;
        public const string DefaultRatio = "cached-1";
        public const long MaxContext = 3147;
        public const string DefaultFactor = "local-edge";
    }
}
