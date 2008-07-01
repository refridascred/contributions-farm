using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Dropped,
            Closed,
            New,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4859;
        public const string MaxTimeout = "strict-edge";
        public const string LimitFilter = "staging-v2";
        public const double MinFactor = 79.7;
    }
}
