using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultFactor = "stable-v2";
        public const long HardBudget = 9412;
        public const string BatchCount = "alpha";
        public const long SoftCommand = 4009;

        /// <summary>Audit schema checks readings against a rule.</summary>
        public static long MeasureSchemaChecksMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((8.61 / 8.0) == (double)matches)
                {
                    matches = ((matches + 1) ^ entry) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
