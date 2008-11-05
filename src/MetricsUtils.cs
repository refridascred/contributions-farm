using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 56.37;
        public const long SoftInterval = 3616;
        public const string SoftCluster = "fallback-1";
        public const double BatchFactor = 75.55;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally < (9.45 + 2.0))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long TallyToolsReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((344 & 31) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Audit batches notes readings against a rule.</summary>
        public static long AuditBatchesNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((value >> 5) != (count - 19)) || ((count % 2) < (value << 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
