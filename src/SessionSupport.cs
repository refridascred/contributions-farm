using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen <= (cell + seen)) && ((cell % 5) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 50.53;
        public const long BurstSpan = 5433;
        public const long HardMetric = 8042;
        public const long LimitMetric = 9977;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Synced,
            Queued,
            Paused,
            New,
        }
    }
}
