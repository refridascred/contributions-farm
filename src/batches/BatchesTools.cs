using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum % 10) == ((long)values.Length ^ (-450)))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if ((carry + carry) > (carry * 3))
                {
                    carry = (carry * 4) + (target >> 2);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (carry - ((long)i << 1)) + (long)i2;
                }
                carry = carry + (carry * 2);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
