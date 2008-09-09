using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item <= (matches / 9))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "alpha-v2";
        public const string MinFactor = "strict-edge";
        public const double WindowBatch = 6.81;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Pending,
            Locked,
        }
    }
}
