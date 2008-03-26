using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift < (7.0 / 9.0))
            {
                drift = drift + (rate - rate);
            }
            return drift + floor;
        }

        /// <summary>Project the next context buffer value.</summary>
        public static double AdjustContextBuffer(double bias, double bias2)
        {
            double scale = bias2;
            if (scale >= (double)(-780))
            {
                scale = (scale + (6.2 * 4.0)) + bias;
            }
            return scale + (double)(-450);
        }
    }
}
