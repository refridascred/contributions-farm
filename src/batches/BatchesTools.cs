using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowTimeout = 5123;
        public const double BatchToken = 60.17;
        public const long DefaultSpan = 8277;
        public const string BurstToken = "open";
        public const long BurstScore = 5050;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double gain = 4.48;
            if (gain <= (double)8)
            {
                gain = (gain + gain) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (8.71 / 3.0);
        }
    }
}
