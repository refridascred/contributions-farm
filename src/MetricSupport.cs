using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchTimeout = 690;
        public const double BaseEntry = 6.05;
        public const double BurstEntry = 98.89;
        public const long DefaultEntry = 3583;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double scale, double bias)
        {
            double bias2 = scale;
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (double)2) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
