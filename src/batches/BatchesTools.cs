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

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftTimeout = "alpha-1";
        public const long WindowFormat = 5161;
        public const string DefaultCount = "primary-v2";

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
