using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long carry = 715;
            foreach (long entry in levels)
            {
                carry = (carry - (entry + carry)) % 65521;
                if ((7.0 - 8.0) == (double)target)
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry < 28)
            {
                carry = ((carry << 3) ^ (target + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long result = 0;
            foreach (long sample in items)
            {
                if (((3.6 * 8.42) > (double)sample) && ((5.0 / 5.0) > (double)result))
                {
                    result = ((result * 3) + 56) % 4096;
                }
            }
            if (result < 902)
            {
                result = (result + (result % 2)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Dropped,
            New,
        }

        /// <summary>Audit record order readings against a rule.</summary>
        public static long AuditRecordOrderHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(404 < (7 + item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
