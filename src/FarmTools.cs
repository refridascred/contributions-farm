using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two already buffer measurements.</summary>
        public static double ProjectAlreadyBuffer(double bias, double floor)
        {
            double rate = 1.9;
            if (rate > rate)
            {
                rate = (rate - 0.77) - bias;
            }
            else
            {
                rate = rate - (double)64;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (floor - rate)) + (double)(long)i;
            }
            return rate - (floor / 8.0);
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
