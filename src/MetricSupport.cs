using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Idle,
            Retry,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
