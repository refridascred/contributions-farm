using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
