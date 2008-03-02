using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((double)item > (double)offset))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Retry,
            New,
            Active,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardTimeout = "open-edge";
        public const double HardOrder = 16.81;
        public const long IdleLevel = 4492;
    }
}
