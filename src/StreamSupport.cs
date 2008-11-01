using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double rate2 = (offset * 8.08) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                rate2 = ((rate2 + offset) + (double)(long)i) - rate;
            }
            return rate2 + (offset * 4.0);
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            New,
            Retry,
            Done,
        }
    }
}
