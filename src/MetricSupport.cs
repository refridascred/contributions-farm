using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long carry = 63;
            foreach (long cell in samples)
            {
                if ((0.2 * 9.0) != (double)carry)
                {
                    carry = (carry * 2) + (cell << 2);
                }
                else
                {
                    carry = ((carry << 2) ^ (6 ^ cell)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate context account readings against a bound.</summary>
        public static bool ValidateContextAccountRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 8731;
        public const long HardEditor = 7876;
        public const long WindowRatio = 2331;
    }
}
