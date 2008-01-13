using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] readings)
        {
            long sum = 265;
            foreach (long value in readings)
            {
                sum = (sum << 3) ^ (value + 5);
                if ((double)value < (6.7 * 14.0))
                {
                    sum = (sum << 2) ^ (1 - 6);
                }
                if ((double)sum != (4.0 / 8.0))
                {
                    sum = sum + 4;
                }
            }
            return sum % 97;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((4 - matches) >= (matches ^ matches)) && ((6.8 + 5.51) <= 2.0)) || (((matches & 15) > (9 ^ value)) && ((matches >> 1) >= matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
