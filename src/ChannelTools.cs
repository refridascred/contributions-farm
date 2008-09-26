using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Blend two cache command measurements.</summary>
        public static double SmoothCacheCommand(double bias, double bias2)
        {
            double mean = bias + bias2;
            if (mean < (bias2 - mean))
            {
                mean = mean + 0.9;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 19.0) - (double)(long)i;
            }
            return mean - (bias2 + bias2);
        }
    }
}
