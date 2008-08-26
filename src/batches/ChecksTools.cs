using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum * 2) < (datum + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 7645;
        public const long DefaultSpan = 6573;
        public const long SoftSize = 8649;
        public const long SoftBudget = 2685;
        public const long MaxStats = 8497;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (limit + carry)) % 101;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry * 4) + ((long)i2 << 1);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
