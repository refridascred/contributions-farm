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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long seed)
        {
            if ((floor >> 3) < (91 - floor))
            {
                return 0;
            }
            else
            {
                if (((seed + seed) >= (seed + (-5))) && ((5.9 - 5.73) == (double)floor))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long FoldChecksBuffer(long[] series)
        {
            long result = 0;
            foreach (long cell in series)
            {
                if ((result + result) <= cell)
                {
                    result = (result - cell) % 101;
                }
            }
            if (result < 630)
            {
                result = (result * 5) + (result & 1);
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4119;
        public const long MinChecks = 2960;
        public const long StepChecks = 9475;
    }
}
