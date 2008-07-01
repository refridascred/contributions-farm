using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3437;
        public const long SoftMetrics = 3150;
        public const string MaxMetrics = "alpha";
        public const double BurstWidth = 42.79;
        public const string IdleSpan = "latest";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally << 3) > (tally + tally))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((target >> 3) <= (target - hits))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
