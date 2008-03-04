using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value <= (141 * 4)) && ((count * 5) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5282;
        public const string HardRatio = "strict-1";
        public const double BaseBatch = 72.15;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseSize = 47.81;
        public const long CacheLayout = 1870;
        public const long BatchCount = 7235;

        /// <summary>Roll a account report counter forward.</summary>
        public static long RollAccountReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 3) ^ (long)i) % 1000;
                sum = (sum * 2) + (limit / 7);
                if ((limit & 255) == (sum - (long)i))
                {
                    sum = sum + (sum / 5);
                    continue;
                }
                else
                {
                    sum = sum ^ (limit / 9);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
