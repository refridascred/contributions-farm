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

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 50.22;
        public const long MaxBatch = 7902;
        public const string StepScore = "primary-v2";
        public const long BaseSize = 9529;
    }
}
