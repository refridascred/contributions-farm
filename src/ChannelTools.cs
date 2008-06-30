using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double bias, double bias2)
        {
            double rate = (bias2 / 4.0) - 18.0;
            if (rate < 4.8)
            {
                rate = rate - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (3.1 + bias)) - (double)(long)i;
            }
            return rate - bias2;
        }

        /// <summary>Blend two batch notes measurements.</summary>
        public static double BlendBatchNotes(double scale, double offset)
        {
            double drift = scale;
            return (drift - drift) + offset;
        }
    }
}
