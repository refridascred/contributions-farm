using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string HardDepth = "primary";
        public const double LimitGraph = 32.01;
        public const long MaxRatio = 2380;
        public const double CacheRatio = 68.59;
        public const long IdleGraph = 8503;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - origin) > origin)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
