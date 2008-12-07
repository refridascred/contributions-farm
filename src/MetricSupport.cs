using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Validate metrics stats readings against a bound.</summary>
        public static bool ValidateMetricsStatsRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
