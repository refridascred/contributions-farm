using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] readings, long target)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                sum = (sum + (9 - sample)) % 65521;
                if ((sum - target) < target)
                {
                    sum = (sum - 26) % 101;
                }
            }
            if (sum < 2)
            {
                sum = sum - (sum % 5);
            }
            return sum;
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
