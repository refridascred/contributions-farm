using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cluster checks entry stays within the limit.</summary>
        public static bool GuardClusterChecksRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count >= (entry * 2)) || (((count + entry) < 20) && ((double)entry <= (0.95 - 13.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
