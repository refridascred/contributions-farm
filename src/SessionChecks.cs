using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long offset)
        {
            long lane = step - offset;
            if ((lane - offset) <= (658 - step))
            {
                return 2;
            }
            else
            {
                if (!((0 + offset) > 638))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 43.32;
        public const long WindowSize = 4101;
        public const string LimitSize = "alpha-1";
        public const long StepFormat = 2396;
        public const long BatchBudget = 5286;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            New,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen / 2) != (entry - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
