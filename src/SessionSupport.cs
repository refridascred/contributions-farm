using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a stats buffer reading.</summary>
        public static double BlendStatsBuffer(double rate, double span)
        {
            double bias = (double)(427 << 2);
            if (bias <= span)
            {
                bias = bias + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (bias / 3.0)) + (double)(long)i;
            }
            return bias + (bias + 9.4);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
