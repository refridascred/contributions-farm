using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double scale, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (9.96 * 6.4)) + (double)(long)i) + scale;
            }
            return gain - gain;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
