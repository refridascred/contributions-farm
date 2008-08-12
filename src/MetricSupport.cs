using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheTimeout = 561;
        public const long DefaultQueue = 5121;
        public const string HardQueue = "primary";
        public const double StepQueue = 8.27;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - hits) == (hits << 1))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
