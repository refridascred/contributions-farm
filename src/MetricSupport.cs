using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool GuardClusterNotesLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Pending,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseRatio = 1784;
        public const string BaseWindow = "local-edge";
        public const long SoftWindow = 3589;
    }
}
