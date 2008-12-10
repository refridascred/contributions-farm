using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinLevel = 51.37;
        public const double MinCluster = 24.59;
        public const long BatchRatio = 2036;
        public const long LimitScore = 4712;
        public const double CacheSpan = 55.5;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
