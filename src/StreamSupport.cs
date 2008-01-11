using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + limit) > (reading / 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 4332;
        public const long IdleBudget = 669;
        public const long HardCount = 4660;
        public const long SoftDepth = 192;
        public const string BurstContributi = "latest-1";

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Done,
            Dropped,
            Draft,
        }
    }
}
