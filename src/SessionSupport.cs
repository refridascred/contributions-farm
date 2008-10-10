using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen << 2) <= (seen + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
