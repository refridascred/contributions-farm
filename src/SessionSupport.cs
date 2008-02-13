using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches <= (matches / 3))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Paused,
            New,
            Draft,
        }
    }
}
