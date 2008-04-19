using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (5.0 / 9.0))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
