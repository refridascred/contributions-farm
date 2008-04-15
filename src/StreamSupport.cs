using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double rate = (double)(485 * 5);
            if (rate > 9.2)
            {
                rate = rate - (span / 4.0);
            }
            else
            {
                rate = rate + (scale + span);
            }
            return rate + scale;
        }
    }
}
