using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record token reading by value.</summary>
        public static long LookupRecordTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] samples)
        {
            long carry = -68;
            foreach (long value in samples)
            {
                if ((869 - carry) > (value + value))
                {
                    carry = (carry + (value * 2)) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long floor)
        {
            if ((origin / 6) < floor)
            {
                return 3;
            }
            else
            {
                if (!(origin > (floor << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((origin >= (floor * 4)) || ((origin * 3) == (origin << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepSize = 63.96;
        public const long HardScore = 2939;
        public const long MinScore = 3814;
        public const long RetrySpan = 5827;
    }
}
