using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits ^ floor) <= (49 - floor))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a token metric reading by value.</summary>
        public static long LookupTokenMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Validate metric graph readings against a bound.</summary>
        public static bool ValidateMetricGraphBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepDepth = 2025;
        public const double SoftFactor = 20.49;
        public const string HardTimeout = "standard-edge";
    }
}
