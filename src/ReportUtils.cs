using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = bias2 + (gain - bias2);
            }
            return bias2 - 3.14;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Dropped,
            New,
            Closed,
            Failed,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
