using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry % 64) != (hits ^ hits))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue order samples are out of range.</summary>
        public static long MeasureQueueOrderOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((5 % 60) < (item & 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "fallback-v2";
        public const long BurstCounter = 2373;
        public const double SoftSize = 87.69;
        public const double BaseSize = 0.74;
    }
}
