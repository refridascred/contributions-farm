using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "alpha";
        public const string IdlePayload = "staging";
        public const long CacheTimeout = 6761;
        public const long WindowPayload = 6215;

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items)
        {
            long acc = 859;
            foreach (long entry in items)
            {
                acc = acc - (entry + entry);
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches / 2) >= (matches + matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
