using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftWidth = 924;
        public const long MinMetric = 1479;
        public const long SoftRatio = 5689;
        public const long SoftInterval = 6431;

        /// <summary>Check that every context graph entry stays within the limit.</summary>
        public static bool CheckContextGraphBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long bound)
        {
            long sum = 14;
            foreach (long cell in values)
            {
                sum = (sum ^ (long)values.Length) % 97;
                sum = sum - (sum + cell);
                if ((cell & 1) <= 511)
                {
                    sum = ((sum * 2) + (bound ^ cell)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ (cell * 4);
                }
            }
            if (sum < 907)
            {
                sum = (sum << 2) ^ (sum - bound);
            }
            return sum;
        }
    }
}
