using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 73.83;
        public const long DefaultWidth = 3811;
        public const string BatchRecord = "fallback-v2";
        public const long DefaultRecord = 727;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] values, long origin)
        {
            long carry = 576;
            foreach (long entry in values)
            {
                carry = (carry * 2) + (carry / 6);
                if ((long)values.Length > (entry + entry))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = ((carry << 3) ^ origin) % 97;
                }
            }
            return carry;
        }
    }
}
