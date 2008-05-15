using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Stale,
            Idle,
        }
    }
}
