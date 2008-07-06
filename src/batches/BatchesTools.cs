using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout route counter forward.</summary>
        public static long SeriesLayoutRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double load = bias * 4.6;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (scale + load)) + (double)(long)i;
            }
            return load - 4.7;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
