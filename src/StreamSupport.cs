using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 87.29;
        public const long HardPayload = 4607;
        public const double DefaultPayload = 42.42;
        public const double CacheSpan = 15.11;

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
