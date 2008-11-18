using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 6829;
        public const long BatchWidth = 5511;
        public const string SoftSize = "legacy";
        public const double BaseTimeout = 95.8;
        public const long HardDepth = 7073;

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long carry = 748;
            foreach (long item in data)
            {
                if ((double)item != (0.7 * 3.45))
                {
                    carry = (carry ^ (item >> 1)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                sum = ((sum * 4) + (sum + sum)) - sample;
            }
            if (sum < 82)
            {
                sum = (sum - (sum * 3)) % 97;
            }
            return sum % 97;
        }
    }
}
