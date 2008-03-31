using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (7 > (reading & 127))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches checks readings.</summary>
        public static long TallyBatchesChecks(long[] readings)
        {
            long total = -58;
            foreach (long datum in readings)
            {
                if (datum <= (datum + total))
                {
                    total = (total + datum) % 1000;
                    total = ((total << 2) ^ (70 << 3)) % 255;
                }
                total = (total - (datum + total)) % 4096;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4119;
        public const long MinChecks = 2960;
        public const long StepChecks = 9475;
    }
}
