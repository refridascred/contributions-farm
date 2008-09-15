using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRatio = 58.09;
        public const long BaseRecord = 702;
        public const long DefaultRecord = 3071;
        public const string HardRatio = "stable-v2";

        /// <summary>Combine window support values into a single score.</summary>
        public static long TotalWindowSupport(long[] values)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ reading) % 255;
                if ((double)reading > (0.1 - 8.26))
                {
                    sum = ((sum * 4) + (sum & 63)) % 97;
                }
            }
            if (sum > 83)
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
