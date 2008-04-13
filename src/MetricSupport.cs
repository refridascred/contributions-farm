using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleLevel = 8082;
        public const long RetryToken = 7200;
        public const long IdleToken = 2779;
        public const double BatchToken = 83.49;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > 11.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }
    }
}
