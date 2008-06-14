using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MinTools = 20.2;
        public const long MaxTools = 9488;
        public const long DefaultDepth = 8740;
        public const double DefaultTools = 77.39;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Failed,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen % 16) <= (offset + seen)) || ((672 << 2) >= (seen + offset)))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
