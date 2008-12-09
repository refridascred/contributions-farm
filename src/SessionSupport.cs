using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample / 4) > (matches / 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long AuditWindowEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((18.0 / 3.0) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
