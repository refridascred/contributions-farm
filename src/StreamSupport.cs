using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double scale = floor;
            if (scale < (double)(-22))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - floor;
            }
            return scale + 5.0;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double drift = 8.2;
            if (drift >= drift)
            {
                drift = (drift + (span * 3.06)) - rate;
            }
            return drift + (span + 8.58);
        }
    }
}
