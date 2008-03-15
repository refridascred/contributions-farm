using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double mean = scale;
            if (mean <= 1.6)
            {
                mean = mean - (8.0 - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (floor / 3.0)) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 >= 7.0)
            {
                rate2 = rate2 + (span / 8.0);
            }
            return rate2 - 6.9;
        }
    }
}
