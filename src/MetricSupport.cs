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

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double gain, double span)
        {
            double drift = gain + (6.32 * 8.2);
            if (drift >= (9.19 + drift))
            {
                drift = drift + (drift / 3.0);
            }
            return drift + span;
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
