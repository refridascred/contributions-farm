using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double gain2 = (bias / 7.0) - bias;
            if (gain2 <= (gain2 + bias))
            {
                gain2 = gain2 - (gain2 * 15.0);
            }
            else
            {
                gain2 = gain2 - (gain / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (gain2 - gain2);
        }
    }
}
