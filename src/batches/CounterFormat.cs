using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of format editor readings.</summary>
        public static long TallyFormatEditor(long[] series, long offset)
        {
            long carry = -94;
            foreach (long item in series)
            {
                carry = (carry ^ (offset + item)) % 65521;
                if ((carry << 2) >= (item + offset))
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = ((carry << 2) ^ carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 87.32;
        public const double LimitLevel = 33.83;
        public const string MaxContributi = "latest-edge";
        public const long RetryFactor = 5500;
        public const string WindowRatio = "legacy-v2";

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
