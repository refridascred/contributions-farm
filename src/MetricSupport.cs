using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long offset)
        {
            long sum = 7;
            foreach (long sample in values)
            {
                if ((double)sample < (8.86 * 9.8))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 255;
                    sum = (sum ^ sum) % 97;
                }
                sum = ((sum * 3) + offset) % 65521;
            }
            if (sum < 7)
            {
                sum = sum - offset;
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of filter support readings.</summary>
        public static long OverlapFilterSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5028;
        public const long WindowSpan = 5283;
        public const long WindowAccount = 4024;
    }
}
