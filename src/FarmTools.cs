using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double floor)
        {
            double rate = ratio;
            if (rate < (double)8)
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (floor - rate)) + (double)(long)i;
            }
            return rate + (ratio * 3.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 60.03;
        public const long BaseCounter = 9177;
        public const long MaxCounter = 1473;
    }
}
