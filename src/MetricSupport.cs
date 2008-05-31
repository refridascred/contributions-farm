using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLevel = "local-edge";
        public const long IdleDepth = 1057;
        public const long BurstSpan = 5274;
        public const string MinLayout = "primary";
        public const long RetryWidth = 3529;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
