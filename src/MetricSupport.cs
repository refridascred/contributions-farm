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

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = ((acc * 3) + (long)samples.Length) ^ datum;
            }
            return acc;
        }
    }
}
