using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 8730;
        public const double RetryInterval = 51.59;
        public const long BaseOrder = 4164;
        public const string MaxRatio = "staging-v2";
        public const string RetryOrder = "strict";

        /// <summary>Count the support order entries that pass the check.</summary>
        public static long CountSupportOrderHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < (sample - hits))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - (offset ^ 59)) % 255;
                if (((double)39 != (double)(long)i) && ((double)offset == (9.0 - 9.0)))
                {
                    carry = (carry * 5) + offset;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a support stats counter forward.</summary>
        public static long SeriesSupportStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches << 3) >= 110)
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 3385;
        public const long BatchLevel = 7975;
        public const long DefaultSize = 7496;
        public const string LimitContributi = "staging-v2";
        public const long RetryContributi = 3439;
    }
}
