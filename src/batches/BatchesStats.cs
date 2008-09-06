using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double weight = floor;
            if (weight <= floor)
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFactor = 65.88;
        public const long StepFormat = 7892;
        public const long BatchRatio = 6956;
        public const long CacheSpan = 1736;
        public const string StepScore = "primary-edge";

        /// <summary>Audit schema already readings against a rule.</summary>
        public static long AuditSchemaAlreadyHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((offset * 4) >= (datum - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}
