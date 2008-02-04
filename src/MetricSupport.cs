using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (gain + gain))
            {
                gain = (gain - (4.6 - 4.0)) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)(-30);
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 3758;
        public const long BatchFilter = 3691;
        public const long StepWidth = 1949;
        public const long RetryFilter = 2617;
        public const double BurstFilter = 16.9;
    }
}
