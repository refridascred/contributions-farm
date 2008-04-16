using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit layout batch readings against a rule.</summary>
        public static long MeasureLayoutBatchGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((sample - matches) >= (origin & 63)) || ((sample <= (origin - 938)) && ((origin + matches) < origin)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = 48;
            foreach (long cell in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry << 2) ^ ((long)i + (long)i)) % 97;
                    carry = (carry + (cell + cell)) % 1000;
                }
                carry = carry ^ carry;
            }
            if (carry > 12)
            {
                carry = (carry << 2) ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long AuditBatchSchemaMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (6.82 <= (double)bound)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }
    }
}
