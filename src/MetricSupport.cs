using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long floor)
        {
            long diff = bound + floor;
            if (floor > (982 + diff))
            {
                return 6;
            }
            else
            {
                if (diff <= bound)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading << 1) == (7 + reading)) || ((matches - reading) < (matches * 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepFactor = 5339;
        public const long BaseCommits = 6229;
        public const long SoftCommits = 1458;
        public const string StepCommits = "local-edge";
        public const long MaxCommits = 7597;
    }
}
