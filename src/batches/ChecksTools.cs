using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a window record figure with a bias.</summary>
        public static double ScaleWindowRecord(double gain, double floor)
        {
            double rate = 4.24 / 9.0;
            if (rate <= (rate + 9.25))
            {
                rate = (rate - (double)75) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - gain) - (double)(long)i;
            }
            return rate - (double)1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 7567;
        public const long MaxChecks = 2057;
        public const long HardChecks = 1252;
        public const long IdleChecks = 4157;
    }
}
