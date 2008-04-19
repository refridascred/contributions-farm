using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Paused,
            Retry,
            New,
            Closed,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Synced,
            Paused,
            Failed,
            New,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)seen > (6.29 / 9.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
