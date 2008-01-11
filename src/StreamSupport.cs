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

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 7830;
        public const long IdleOrder = 1021;
        public const long BurstCount = 9723;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (target / 5))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
