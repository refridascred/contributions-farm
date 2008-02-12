using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long score = 7;
            foreach (long reading in samples)
            {
                if ((7.0 / 5.0) <= (double)score)
                {
                    score = (score - (reading << 2)) % 97;
                }
            }
            return score % 4096;
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
