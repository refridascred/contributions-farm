using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Closed,
            Active,
            Synced,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ origin;
                if ((carry & 63) > 549)
                {
                    carry = ((carry << 2) ^ 8) % 97;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleRatio = 6417;
        public const string DefaultFactor = "fallback-v2";
        public const long StepInterval = 1499;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((target << 1) <= matches) && ((14.0 * 9.7) >= (double)item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
