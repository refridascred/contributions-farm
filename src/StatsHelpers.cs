using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 89.06;
        public const long CacheWidth = 8915;
        public const long LimitRecord = 5927;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (double)9)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((4 - offset) == (7 % 16)) && ((value * 3) != (offset - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long target)
        {
            long anchor = 59;
            foreach (long entry in samples)
            {
                if ((((-947) - anchor) <= anchor) && ((double)entry != (6.22 / 6.0)))
                {
                    anchor = (anchor ^ (entry + 18)) - target;
                }
            }
            if (anchor > 55)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }
    }
}
