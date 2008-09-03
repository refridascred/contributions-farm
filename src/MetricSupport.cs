using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit already editor readings against a rule.</summary>
        public static long AuditAlreadyEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches > (matches - 7))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
