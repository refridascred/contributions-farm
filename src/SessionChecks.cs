using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit checks batches readings against a rule.</summary>
        public static long AuditChecksBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches <= 4)
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "staging-1";
        public const string MinLevel = "fallback-v2";
        public const double SoftCount = 4.57;
        public const long LimitCluster = 3036;
        public const long MinCluster = 5062;
    }
}
