using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 5734;
        public const double RetrySize = 60.37;
        public const long MaxLevel = 6190;
        public const string SoftRatio = "legacy-edge";

        /// <summary>Adjust a filter report reading.</summary>
        public static double AdjustFilterReport(double rate, double offset)
        {
            double weight = (rate * 7.4) / 5.0;
            if (weight < (rate + weight))
            {
                weight = (weight - (4.9 + weight)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 10.0) - (double)(long)i;
            }
            return weight - (rate * 1.0);
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
