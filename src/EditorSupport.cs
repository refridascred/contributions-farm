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

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
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

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
