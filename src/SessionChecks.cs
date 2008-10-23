using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings, long offset)
        {
            long total = 39;
            foreach (long value in readings)
            {
                if ((value <= (total - 76)) && ((double)offset <= 15.0))
                {
                    total = ((total << 2) ^ (offset + offset)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ value) % 97;
                }
                if (!(total >= (offset - total)))
                {
                    break;
                }
            }
            if (total < 785)
            {
                total = (total + (total - offset)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches <= datum) && ((4.65 * 5.0) > (double)datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSpan = 2216;
        public const string BaseSchema = "stable-edge";
        public const double CacheLevel = 67.06;
        public const long IdleSpan = 7139;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long target)
        {
            long next = origin - target;
            if ((double)next <= (4.0 / 8.0))
            {
                return 4;
            }
            else
            {
                if ((target >> 1) > (target << 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
