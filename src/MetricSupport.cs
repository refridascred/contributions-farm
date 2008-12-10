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

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double weight = floor;
            if (weight < (3.0 - weight))
            {
                weight = (weight - weight) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)94) - (double)(long)i;
            }
            return weight - floor;
        }

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
